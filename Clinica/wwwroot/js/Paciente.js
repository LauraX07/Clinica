var select = document.querySelector("#inputO");

select.addEventListener("change", function () {
    const pag = this.value;

    if (pag && pag !== "Paciente") {
        window.location.href = pag;
    }
});
