const form = document.getElementById("form");

form.addEventListener("submit", (el)=>{
    if(form[0].value == "" && form[1].value == "" && form[2].value == ""){
        el.preventDefault();
        form[0].style="border:solid red 2px";
        form[0].placeholder = "Please enter a value!";

        form[1].style="border:solid red 2px";
        form[1].placeholder = "Please enter a value!";

        form[2].style="border:solid red 2px";
        form[2].placeholder = "Please enter a value!";
    }
    if(form[0].value == ""){
        el.preventDefault();
        form[0].style="border:solid red 2px";
        form[0].placeholder = "Please enter a value!";
    }
    if(form[1].value == ""){
        el.preventDefault();
        form[1].style="border:solid red 2px";
        form[1].placeholder = "Please enter a value!";
        }
    if(form[2].value == ""){
        el.preventDefault();
        form[2].style="border:solid red 2px";
        form[2].placeholder = "Please enter a value!";
    }
}, false);