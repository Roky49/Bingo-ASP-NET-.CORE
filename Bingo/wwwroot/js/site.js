// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
   
    $("#empezar").click(function () {
        $(this).fadeOut("slow");
       
        $("#pantalla").delay(1000).fadeIn("slow");
        var loteria = GenerarNumeros();
        var cont = 0;
        console.log(loteria);
        $("#numerobingo").delay(2000).click();
        //$.each(loteria, function (index, element) {
        //    $("#numerobingo").text(loteria[element]);
        //    var numero = $("#numerobingo").text();
        //    $("#" + numero).css("color", "red");
           
        //});
        $("#numerobingo").on("click", function () {
            $("#numerobingo").text(loteria[cont]);
            var numero = $("#numerobingo").text();
            $("#" + numero).css("color", "red");
            cont++;
        });
      

        function SiguienteNumero() {
            $("#numerobingo").trigger("click");
        }

        setInterval(SiguienteNumero, 9000);
    });
    //funcion para pasar los numeros 
    
  
   
});


function GenerarNumeros() {

    var n = 91;
    const arr = new Array(n);
    for (let i = 0; i < n; i++) {
        arr[i] = i + 1;
    }

    arr.sort(() => Math.random() > 0.5 ? 1 : -1);
    const loteria = arr.slice(0, 91);
    
    return loteria;
}

