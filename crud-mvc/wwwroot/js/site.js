var fillform = (address) => {
    cleanCamp();
    document.getElementById('address').value = address.logradouro;
    document.getElementById('district').value = address.bairro;
    document.getElementById('state').value = address.uf;
    document.getElementById('city').value = address.localidade;

}


var cleanCamp = () => {
    document.getElementById('address').value = '';
    document.getElementById('district').value = '';
    document.getElementById('state').value = '';
    document.getElementById('city').value = '';

}

var cepValid = (cep) => cep.length == 8 && /^[0-9]+$/.test(cep);
var searchCep = async () => {


    cleanCamp();
    var cep = document.getElementById('cep').value;
    var url = `https://viacep.com.br/ws/${cep}/json/`;
    if (cepValid(cep)) {
        var data = await fetch(url);

        var address = await data.json();
        if (address.hasOwnProperty('erro')) {
            document.getElementById('city').value = "Cep does not exist!";
            document.getElementById('state').value = "Cep does not exist!";
            document.getElementById('district').value = "Cep does not exist!";
            document.getElementById('address').value = "Cep does not exist!";
            document.getElementById("cep").focus();

        }
        else {
            console.log(address);
            fillform(address);

        }
    }


    else {
        document.getElementById('city').value = "Cep does not exist!";
        document.getElementById("cep").focus();
    }

}







document.getElementById('cep').addEventListener('focusout', searchCep);
