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
        texbox_tex_a_copiar.value = options;
        copiarContenidoTextarea("texto_a_copiar");
    });
});


function copiarContenidoTextarea(idTextarea) 
{
    // Obtener el textarea por su ID
    var textarea = document.getElementById(idTextarea);
    
    // Verificar que el textarea existe
    if (textarea) {
        // Seleccionar el contenido del textarea
        textarea.select();
        textarea.setSelectionRange(0, 99999); // Para móviles

        // Intentar copiar el contenido al portapapeles
        try {
            document.execCommand('copy');
            alert('Contenido copiado al portapapeles');
        } catch (err) {
            alert('No se pudo copiar el contenido: ', err);
        }
    } else {
        alert('Textarea con ID ' + idTextarea + ' no encontrado');
    }
}

