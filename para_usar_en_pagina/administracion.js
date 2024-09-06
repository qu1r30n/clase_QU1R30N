document.addEventListener('DOMContentLoaded', function () {
    const tabs = document.querySelectorAll('.tab-button');
    const panes = document.querySelectorAll('.tab-pane');

    tabs.forEach(tab => {
        tab.addEventListener('click', function () {
            tabs.forEach(t => t.classList.remove('active'));
            this.classList.add('active');

            const targetPane = document.getElementById(this.dataset.tab);
            panes.forEach(pane => pane.classList.remove('active'));
            if (targetPane) {
                targetPane.classList.add('active');
            } else {
                console.error('No se encontró el pane con el ID: ' + this.dataset.tab);
            }
        });
    });
});



document.addEventListener('DOMContentLoaded', function () {

    const listbox = document.getElementById('listbox');
    const texbox_tex_a_copiar = document.getElementById('texto_a_copiar');




    document.getElementById('boton_agregar').addEventListener('click', function () {

        // ESTE VAMOA A CAMBIAR PARA RECIBIR LO DE EL IFRAME QUE SE ESTA USANDO EN ESTE MOMENTO



        const newOption = prompt('Ingresa el nuevo valor para agregar:');
        if (newOption) {
            const option = document.createElement('option');
            option.value = newOption;
            option.textContent = newOption;
            listbox.appendChild(option);
        }



    });






    document.getElementById('boton_eliminar_seleccionado').addEventListener('click', function () {
        Array.from(listbox.selectedOptions).forEach(option => option.remove());
    });

    document.getElementById('boton_eliminar_todos').addEventListener('click', function () {
        listbox.innerHTML = '';
    });

    document.getElementById('boton_eliminar_ultimo').addEventListener('click', function () {
        if (listbox.options.length > 0) {
            listbox.remove(listbox.options.length - 1);
        }
    });

    document.getElementById('boton_copiar').addEventListener('click', function () {
        const options = Array.from(listbox.options).map(option => option.text).join('\n');
                
        // Copia el texto al portapapeles
        navigator.clipboard.writeText(options)
        .then(() => alert('Texto copiado al portapapeles')) // Notifica al usuario que el texto se ha copiado
        .catch(err => alert('Error al copiar texto: ' + err)); // Notifica al usuario si hubo un error


    });




});

