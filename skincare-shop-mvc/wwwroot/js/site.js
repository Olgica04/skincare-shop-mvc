const navigationItems = document.querySelectorAll('.categories-navigation-items');
const categories = document.querySelectorAll('.products-container');
const confirmOrder = document.querySelector('.confirm-order');
const cancelOrder = document.querySelector('.cancel-order');
const cancel = document.querySelector('.cancel');
const payment = document.querySelector('.payment');
const message = document.querySelector('.message-container');
const confirm = document.querySelector('.confirm-container');
const payBtn = document.querySelector('.order');

for (let i = 0; i < navigationItems.length; i++) {
    navigationItems[i].addEventListener('click', function () {
        categories.forEach(el => el.classList.add('hidden'));
        navigationItems.forEach(el => el.classList.remove('active'));
        categories[i].classList.remove('hidden');
        navigationItems[i].classList.add('active');
    });
};

confirmOrder.addEventListener('click', function () {
    payment.classList.remove('hidden');
});

cancelOrder.addEventListener('click', function () {
    cancel.classList.remove('hidden');
});

payBtn.addEventListener('click', function () {
    confirm.classList.add('hidden');
    message.classList.remove('hidden');
});