document.querySelectorAll(".btntroca").forEach(btn => {

    btn.addEventListener("click", () => {

        const login = document.querySelector(".LoginM");
        const cad = document.querySelector(".containerM");

        const isLoginVisible = login.style.display !== 'none';

        if (isLoginVisible) {
            login.style.opacity = 0;

            setTimeout(() => {
                login.style.display = "none";

                cad.style.display = "block";
                cad.style.opacity = 1;
            }, 800);
        }
        else {
            cad.style.opacity = 0;
            setTimeout(() => {
                cad.style.display = "none";

                login.style.display = "flex";

                login.style.opacity = 1;
            }, 800)
        }
    });
});

document.querySelectorAll(".form-control").forEach(select => {

    select.addEventListener("change", function () {
        const pag = this.value;

        if (pag) {
            window.location.href = pag;
        }
    })
});

