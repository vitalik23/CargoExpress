function calc(weight, price) {
     weight = parseFloat(calculate.WeightCargo.value);
     price = parseFloat(calculate.PriceCargo.value);
    var result = "";

    if ((calculate.WeightCargo.value == "") || (calculate.PriceCargo.value == "")) {
        document.getElementById('result1').innerHTML = "Будь-ласка введіть данні!";
    }

    if (weight < 30) {
        if (document.getElementById('Radio1').checked) {
            result = 2.5 * weight + 22 + (0.005 * price) + 15;
        }
        else if (document.getElementById('Radio2').checked) {
            result = 2.5 * weight + 22 + (0.005 * price) + 30;
        }
        else {
            result = 2.5 * weight + 22 + (0.005 * price);
        }
        document.getElementById('result1').innerHTML = result;
    }

    if (weight > 30) {
        if (document.getElementById('Radio1').checked) {
            result = 3 * weight + 22 + (0.005 * price) + 15;
        }
        else if (document.getElementById('Radio2').checked) {
            result = 3 * weight + 22 + (0.005 * price) + 30;
        }
        else {
            result = 3 * weight + 22 + (0.005 * price);
        }

        document.getElementById('result1').innerHTML = result;
    }
    if (weight < 0 || price < 0) {
        document.getElementById('result1').innerHTML = "Вартість або вага вантажу не може бути від'ємною!";
    }

    document.getElementById('result').innerHTML = "Вартість доставки";
}


