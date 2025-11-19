document.querySelectorAll(".btntroca").forEach(btn => {

    btn.addEventListener("click", () => {

        const login = document.querySelector(".LoginP");
        const cad = document.querySelector(".containerP");


        if (containerP.style.display === 'none') {
            login.style.display = "none";
            cad.style.display = "block";
        }

        else {
            cad.style.display = "none";
            login.style.display = "flex";
        }
    });
});
