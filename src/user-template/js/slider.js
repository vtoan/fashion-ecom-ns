function Slider(
    container,
    prev,
    next,
    duration = 500,
    repeat = 3000,
    callBack
) {
    let target = document.querySelector(container);
    let navigator = document.querySelectorAll(prev + ", " + next);
    let handler = target.querySelector(".slider-handle");
    //root
    let items = target.querySelectorAll(".slider-item");
    items.forEach((obj, idx) => obj.setAttribute("offset", idx + 1));
    let widthItem = Math.round(items.item(0).offsetWidth);
    let offSetItems = items.length - 1;
    //=========== Clone ===========
    //cloning item first
    let itemCloneFirst = items.item(offSetItems).cloneNode(true);
    itemCloneFirst.setAttribute("offset", 0);
    itemCloneFirst.classList.add("clone");
    handler.prepend(itemCloneFirst);
    //cloning item last
    let itemCloneLast = items.item(0).cloneNode(true);
    itemCloneLast.setAttribute("offset", offSetItems + 2);
    itemCloneLast.classList.add("clone");
    handler.append(itemCloneLast);
    offSetItems += 2;
    //=========== Event ===========
    //handelr
    function slideTo(item) {
        //callback
        if (callBack) callBack(item);
        //
        let offSet = parseInt(item.getAttribute("offset"));
        //calutate tranlate
        let translateX = -offSet * widthItem;
        //check end or start slide
        let backSlideOffset = -1;
        if (item.classList.contains("clone")) {
            backSlideOffset = offSet > 0 ? 1 : offSetItems - 1;
            item = handler.querySelector(
                ".slider-item:nth-child(" + (backSlideOffset + 1) + ")"
            );
        }
        //start-sliding
        navigator.forEach((item) => (item.style.pointerEvents = "none"));
        handler.style.transform = `translateX(${translateX}px)`;
        handler.style.transition = `transform ${duration / 1000}s ease`;
        item.classList.add("active");
        //end-sliding
        setTimeout(function () {
            navigator.forEach((item) => (item.style.pointerEvents = ""));
            handler.style.transition = "";
            if (backSlideOffset > 0)
                handler.style.transform = `translateX(${
                    -backSlideOffset * widthItem
                }px)`;
        }, duration);
    }
    //=========== Add ==========
    //Add event listener
    navigator.item(0).addEventListener("click", () => {
        let item = handler.querySelector(".slider-item.active");
        item.classList.remove("active");
        slideTo(item.previousElementSibling);
    });
    navigator.item(1).addEventListener("click", () => {
        let item = handler.querySelector(".slider-item.active");
        item.classList.remove("active");
        slideTo(item.nextElementSibling);
    });
    //Repeat;
    if (repeat != 0) {
        setInterval(function () {
            navigator.item(1).click();
        }, repeat);
    }
    //Add defualt;
    handler.style.transform = `translateX(-${widthItem}px)`;
    target.querySelector(".slider-item:nth-child(2)").classList.add("active");
}
// Slider(".slider-container", ".slider-prev", ".slider-next");
