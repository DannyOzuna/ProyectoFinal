function msjAlert(title, icon){
    Swal.fire({
        //position: 'top-end',
        icon,
        title,
        showConfirmButton: false,
        timer: 1500
      })
}

function msjConfim(title,text,icon){
    return new Promise (resolve => {
        Swal.fire({
            title,
            text,
            icon,
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            cancelButtonText: 'Cancelar',
            confirmButtonText: '¡Sí, bórralo!'
          }).then((result) => {
              resolve(result.isConfirmed);
          })
    })
}

function msjValidation(title, text, icon){
    Swal.fire({
        icon,
        title,
        text,
        footer: '<a href>Why do I have this issue?</a>'
      })
}

function loading(){
    Swal.fire({
        imageUrl: './image/spinner.gif',
        imageWidth: 400,
        imageHeight: 300,
        imageAlt: 'Custom image',
        showConfirmButton: false,
      })
}

function mascara(d,sep,pat,nums){
    if(d.valant != d.value){
        val = d.value
        largo = val.length
        val = val.split(sep)
        val2 = ''
        for(r=0;r<val.length;r++){
            val2 += val[r]
        }
        if(nums){
            for(z=0;z<val2.length;z++){
                if(isNaN(val2.charAt(z))){
                    letra = new RegExp(val2.charAt(z),"g")
                    val2 = val2.replace(letra,"")
                }
            }
        }
        val = ''
        val3 = new Array()
        for(s=0; s<pat.length; s++){
            val3[s] = val2.substring(0,pat[s])
            val2 = val2.substr(pat[s])
        }
        for(q=0;q<val3.length; q++){
            if(q ==0){
                val = val3[q]
            }
            else{
                if(val3[q] != ""){
                    val += sep + val3[q]
                    }
            }
        }
        d.value = val
        d.valant = val
    }
}//Fin de la funcion mascara para los elementos.


function accessDOMElement(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("Marcadores").then(lsVehiculos => {
        var json = JSON.parse(lsVehiculos);
        //PARA AGREGAR LA UBICACION INICIAL DEL MAPA
        var mymap = L.map('Map').setView([18.47186, -69.89232], 8);

        //PARA AGREGAR EL MAPA
        L.tileLayer('http://a.tile.openstreetmap.fr/hot/{z}/{x}/{y}.png', {
            maxZoom: 18,
            id: 'mapbox/streets-v11',
            tileSize: 512,
            zoomOffset: -1,
            accessToken: 'pk.eyJ1IjoidXN1YXJpb3BhcmF0YXJlYSIsImEiOiJja21oNXl0bjIwMTQwMm5sZmVzMXVndjFlIn0.nfG_MJzF7nZznTEul_-XyQ'
        }).addTo(mymap);


        for (var i in json) {

            L.marker([json[i].latitud, json[i].longitud]).addTo(mymap)
                .bindPopup(`

                                <img src="${json[i].foto}" class="card-img-top" alt="..."><br>
                                <strong>Marca: </strong>${json[i].marca}<br>
                                <strong>Modelo: </strong>${json[i].modelo}<br>
                                <strong>Año: </strong>${json[i].anio}<br>
                                <strong>Color: </strong>${json[i].color}

                             `).openPopup();

        }
    })
}

function guarLocalStorage(nombreUser) {
    localStorage.setItem('token', nombreUser);
}

validarToken();

function validarToken() {
    if (localStorage.length > 0) {
        window.navigator("/Index");
    }
    else {
        window.navigator("/registrarcliente");
    }
}

