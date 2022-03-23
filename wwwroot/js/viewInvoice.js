// Toggle the delete invoice modal

const modal = document.querySelector(".modal");
const deleteInvoiceBtn = document.querySelector(".delete-link");
const deleteModalContent = document.querySelector(".delete-modal-content");
const cancelDeleteBtn = document.querySelector('.cancel-btn');

deleteInvoiceBtn.addEventListener("click", (event) => {
    event.preventDefault();
    modal.style.display = "block";
});

modal.addEventListener('click', (event) => {
    if(event.target !== modal) {
        // do nothing
    } else {
        modal.style.display = "none";
    }
})


cancelDeleteBtn.addEventListener('click', ()=> {
    modal.style.display = "none";
})
