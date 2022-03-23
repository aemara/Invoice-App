//Submits the create/edit invoice form
const createInvoiceForm = document.querySelector('.create-invoice-form');
const editInvoiceForm = document.querySelector('.edit-invoice-form');
const saveChangesLink = document.querySelector('.save-changes-link');


saveChangesLink.addEventListener('click', () => {
    console.log("form was called");
    if(createInvoiceForm != null) createInvoiceForm.submit();
    if(editInvoiceForm != null) editInvoiceForm.submit();
})

//Changing the total price of an item as the user changing its quantity and price
//in CreateInvoice page.
function addDynamicTotalPrice() {

    const itemInputWraps = document.querySelectorAll('.new-item-wrap');
    itemInputWraps.forEach(item => {
        const itemQtyInput = item.querySelector('.item-qty-input');
        const itemPriceInput = item.querySelector('.item-price-input');
        const itemTotalPriceValue = item.querySelector('.item-total-price-value');

        itemQtyInput.addEventListener('change', (event) => {
            let qty = event.target.value;
            itemTotalPriceValue.innerText = itemPriceInput.value * qty;
        })

        itemPriceInput.addEventListener('change', (event) => {
            let price = event.target.value;
            itemTotalPriceValue.innerText = itemQtyInput.value * price;
        })
    })

}
addDynamicTotalPrice();


//Adding a new item to the list

const itemListForm = document.querySelector('.item-list-form');
const addItemBtn = document.querySelector('.add-item-btn');

function itemCount() {
    const itemElements = document.querySelectorAll('.new-item-wrap');
    return itemElements.length;

}

let nextItemIndex = itemCount();

function addNewItem() {
    
    const newDiv = document.createElement("div");
    newDiv.classList.add(`new-item-wrap`);
    newDiv.classList.add(`new-item-${nextItemIndex}`);

    newDiv.innerHTML = `
                        <div class="item-input-wrap item-input-name-wrap" >
                            <label for="item-name">Item Name</label>
                            <input type="text" id="Input.Items_${nextItemIndex}__Name" name="Input.Items[${nextItemIndex}].Name" />
                        </div >

        <div class="qty-price-total-delete-wrap">
            <div class="item-input-wrap item-input-quantity-wrap">
                <label for="quantity">Qty.</label>
                <input type="number"  value="0" class="item-qty-input" id="Input.Items_${nextItemIndex}__Quantity" name="Input.Items[${nextItemIndex}].Quantity" class="item-qty-input" />
            </div>
            <div class="item-input-wrap item-input-price-wrap">
                <label for="price">Price</label>
                <input type="number" value="0" class="item-price-input" id="Input.Items_${nextItemIndex}__Price" name="Input.Items[${nextItemIndex}].Price" />
            </div>

            <div class="item-total-price-wrap">
                <p class="item-total-price-label">Total</p>
                <p class="item-total-price-value">0</p>
            </div>

            <svg class="delete-item-icon delete-icon-item2"
                width="13"
                height="16"
                xmlns="http://www.w3.org/2000/svg">
                <path d="M11.583 3.556v10.666c0 .982-.795 1.778-1.777 1.778H2.694a1.777 1.777 0 01-1.777-1.778V3.556h10.666zM8.473 0l.888.889h3.111v1.778H.028V.889h3.11L4.029 0h4.444z"
                    fill="#888EB0"
                    fill-rule="nonzero" />
            </svg>
        </div>`;

    itemListForm.append(newDiv);
    nextItemIndex = itemCount();
    console.log(`Item count after adding: ${itemCount()}`);
}


addItemBtn.addEventListener('click', (event) => {
    event.preventDefault();
    addNewItem();
    addDynamicTotalPrice();
    attachDeleteListeners();
})




//Deleting an item when creating/editing invoice

function extractIndex(className) {
    return parseInt(className.slice(-1));
}


function updateIndices() {
    const newItemElements = document.querySelectorAll('.new-item-wrap');
    newItemElements.forEach((item, i) => {
        newItemElements[i].classList.remove(newItemElements[i].classList[1]);
        newItemElements[i].classList.add(`new-item-${i}`)
        
        newItemElements[i].querySelector('input').setAttribute("id", `Input.Items_${i}__Name`);
        newItemElements[i].querySelector('input').setAttribute("name", `Input.Items[${i}].Name`);
        newItemElements[i].querySelector('.item-input-quantity-wrap input').setAttribute("id", `Input.Items_${i}__Quantity`);
        newItemElements[i].querySelector('.item-input-quantity-wrap input').setAttribute("name", `Input.Items[${i}].Quantity`);
        newItemElements[i].querySelector('.item-input-price-wrap input').setAttribute("id", `Input.Items_${i}__Price`);
        newItemElements[i].querySelector('.item-input-price-wrap input').setAttribute("name", `Input.Items[${i}].Price`);
    })  
}


function attachDeleteListeners() {
    const deleteItemIcons = document.querySelectorAll('.delete-item-icon');
    const form = document.querySelector('form');
    
        deleteItemIcons.forEach(deleteIcon => {
            deleteIcon.addEventListener('click', (event) => {
                event.target.parentElement.parentElement.parentElement.remove();
                updateIndices();
                nextItemIndex = itemCount();
            })
        })
    
    
}
attachDeleteListeners();






