console.log("Hello Engee!");

var multiplicar =function(numero1){
    return function(numero2) {
        return numero1*numero2;
    };
}

console.log(multiplicar(2)(3));