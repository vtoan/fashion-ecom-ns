function Gallery(obj = ".gallery", nav = ".gallery-nav") {
    let gallery = document.querySelector(obj + " .img");
    let nav_gallery = document.querySelector(nav);
    let widthItemNav = nav_gallery.firstElementChild.offsetWidth;
    //add offset
    nav_gallery
        .querySelectorAll(".img")
        .forEach((item, idx) => item.setAttribute("offset", idx));
    // nav_gallery.children().each((idx, elm) => $(elm).attr("offset", idx));
    //handler
    function showImage(img) {
        gallery.style.backgroundImage = `url(${img})`;
    }

    function changeImage(operation) {
        let itemCurr = nav_gallery.querySelector(".active");
        if (itemCurr != null) itemCurr.classList.remove("active");
        else itemCurr = nav_gallery.firstChild;
        itemCurr =
            operation < 0
                ? itemCurr.previousElementSibling
                : itemCurr.nextElementSibling;
        if (itemCurr == null)
            itemCurr =
                operation < 0
                    ? nav_gallery.querySelector(".img:last-child")
                    : nav_gallery.querySelector(":first-child");
        itemCurr.classList.add("active");
        showImage(itemCurr.querySelector(":first-child").getAttribute("src"));
        nav_gallery.scroll({
            left: Number(itemCurr.getAttribute("offset")) * widthItemNav,
            behavior: "smooth",
        });
    }
    let items = nav_gallery.querySelectorAll(".img");
    items.forEach((item) =>
        item.addEventListener("click", function () {
            let active = nav_gallery.querySelector(".img.active");
            active.classList.remove("active");
            this.classList.add("active");
            showImage(this.querySelector("img").getAttribute("src"));
        })
    );

    document
        .querySelector(obj + " .arrow-prev")
        .addEventListener("click", function () {
            changeImage(-1);
        });
    document
        .querySelector(obj + " .arrow-next")
        .addEventListener("click", function () {
            changeImage(1);
        });
    changeImage(1);
}
