const ButtonLogin = document.getElementById("btn_login")

ButtonLogin.addEventListener('click', () => {login(event)})


function login(event) {
    event.preventDefault();

    var FormData = {
        email: $("#email").val(),
        senha: $("#senha").val()
     }
    
    $.ajax({
        type: "POST",
        datatype: "json",
        contentType: "application/json; charset-UTF-8",
        data: JSON.stringify(FormData),
        url: "http://localhost:7035/api/user",
        success: function (result) {

        },
        error: function (result) {

        }
    })
   
    alert("Passei aqui")
}