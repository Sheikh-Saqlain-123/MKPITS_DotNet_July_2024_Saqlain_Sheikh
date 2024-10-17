function addition(){
   var num1= parseInt(document.getElementById("number1").value);
   var num2= parseInt(document.getElementById("number2").value);

    var result = num1 + num2 ;
    alert("Result of Addition is : "+result);
    document.getElementById("spanId").innerHTML=result;
}

function subtraction(){
    var num1=parseInt( document.getElementById("number1").value);
    var num2= parseInt(document.getElementById("number2").value);

    var result = num1 - num2 ;
    alert("Result of Substraction is : "+result);
    document.getElementById("spanId").innerHTML=result;
}

function multiplication(){
    var num1= parseInt(document.getElementById("number1").value);
    var num2= parseInt(document.getElementById("number2").value);

    var result = num1 * num2 ;
    alert("Result of Multiplication is : "+result);
    document.getElementById("spanId").innerHTML=result;
}


function division(){
    var num1= parseInt(document.getElementById("number1").value);
    var num2= parseInt(document.getElementById("number2").value);

    var result = num1 / num2 ;
    alert("Result of Division is : "+result);
    document.getElementById("spanId").innerHTML=result;
}
