



//Changing the total price of an item as the user changing its quantity and price
//in CreateInvoice page.

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




