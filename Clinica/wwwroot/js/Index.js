const btnPopup = document.querySelector('.popup');
const modal = document.getElementById('modal');
const bnt_close = document.getElementById('btn-close');

btnPopup.addEventListener('click', () => {

    modal.classList.add('ativa');
});

bnt_close.addEventListener('click', () => {
    modal.classList.remove('ativa');
});