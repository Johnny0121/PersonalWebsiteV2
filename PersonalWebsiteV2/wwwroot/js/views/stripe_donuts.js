var stripeDonutModule = function () {
    var stripe = Stripe("pk_test_51Ha85VCBa5lwqRr4DtLBAIp6CyIuD7URviKrOkHctcjZD0eGC5TMGcDRlzdKpYsZ9vM6v1QCBzwPjL9eBKa6gxzR006yktlLGT");
    var donation = { amount: 1.0 };

    $('#donation-email').keyup(function (event) {
        var emailRegex = /\S+@\S+\.\S+/;
        if (emailRegex.test($(this).val())) {
            $('#donation-continue').prop('disabled', false);
        } else {
            $('#donation-continue').prop('disabled', true);
        }
    });

    $('#donation-continue').click(function () {
        const requestObject = {
            amount: donation.amount,
            recipientemailaddress: $('#donation-email').val(),
            description: $('#description').val() || 'No description provided'
        }

        fetch("/api/PaymentIntent", {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(requestObject)
        })
            .then(function (result) {
                $('#payment-form-container').show();

                return result.json();
            })
            .then(function (data) {
                var elements = stripe.elements();
                var style = {
                    base: {
                        color: "#32325d",
                        fontFamily: 'Arial, sans-serif',
                        fontSmoothing: "antialiased",
                        fontSize: "16px",
                        "::placeholder": {
                            color: "#32325d"
                        }
                    },
                    invalid: {
                        fontFamily: 'Arial, sans-serif',
                        color: "#fa755a",
                        iconColor: "#fa755a"
                    }
                };

                var card = elements.create("card", { style: style });

                card.mount("#card-element");

                card.on("change", function (event) {
                    document.querySelector("#stripe-submit").disabled = event.empty;
                    document.querySelector("#card-error").textContent = event.error ? event.error.message : "";
                });
                var form = document.getElementById("payment-form");
                form.addEventListener("submit", function (event) {
                    event.preventDefault();
                    payWithCard(stripe, card, data.clientSecret);
                });
            });
    });

    var payWithCard = function(stripe, card, clientSecret) {
        loading(true);
        stripe.confirmCardPayment(clientSecret, {
            receipt_email: document.getElementById('donation-email').value,
            payment_method: {
                card: card
            }
        })
        .then(function (result) {
            if (result.error) {
                showError(result.error.message + ' Don\'t worry, nothing has went through yet.');
            } else {
                orderComplete(result.paymentIntent.id);
            }
        });
    }

    var orderComplete = function (paymentIntentId) {
        loading(false);
        document.querySelector("#payment-intent-id").innerHTML = `Payment Intent ID: ${paymentIntentId}`;
        document.querySelector(".result-message").classList.remove("d-none");
        document.querySelector("#payment-success").classList.remove("d-none");
        document.querySelector("#payment-form").classList.add("d-none");
        document.querySelector("#payment-container").classList.add("d-none");
        document.querySelector("#stripe-submit").disabled = true;
    };

    var showError = function (errorMsgText) {
        loading(false);
        var errorMsg = document.querySelector("#card-error");
        errorMsg.textContent = errorMsgText;
        setTimeout(function () {
            errorMsg.textContent = "";
        }, 4000);
    };

    var loading = function (isLoading) {
        if (isLoading) {
            document.querySelector("#stripe-submit").disabled = true;
            document.querySelector("#spinner").classList.remove("d-none");
            document.querySelector("#button-text").classList.add("d-none");
        } else {
            document.querySelector("#stripe-submit").disabled = false;
            document.querySelector("#spinner").classList.add("d-none");
            document.querySelector("#button-text").classList.remove("d-none");
        }
    }

    function init() {
        $('#payment-form-container').hide();
        $('#stripe-submit').prop('disabled', true);

        const label = $('.valueSpan');
        const slider = $('#donation-slider');
        var displayText = '£' + Number.parseFloat(slider.val()).toFixed(2);

        label.html(displayText);

        slider.on('input change', () => {
            label.html('£' + Number.parseFloat(slider.val()).toFixed(2));
            donation.amount = slider.val() * 100;
        });
    }

    return {
        init: init,
        stripe: stripe
    }
}();

stripeDonutModule.init();