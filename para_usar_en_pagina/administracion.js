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
    const outputText = document.getElementById('texto_a_copiar');




    document.getElementById('add-button').addEventListener('click', function () {

        // ESTE VAMOA A CAMBIAR PARA RECIBIR LO DE EL IFRAME QUE SE ESTA USANDO EN ESTE MOMENTO



        const newOption = prompt('Ingresa el nuevo valor para agregar:');
        if (newOption) {
            const option = document.createElement('option');
            option.value = newOption;
            option.textContent = newOption;
            listbox.appendChild(option);
        }



    });






    document.getElementById('remove-selected-button').addEventListener('click', function () {
        Array.from(listbox.selectedOptions).forEach(option => option.remove());
    });

    document.getElementById('remove-all-button').addEventListener('click', function () {
        listbox.innerHTML = '';
    });

    document.getElementById('remove-last-button').addEventListener('click', function () {
        if (listbox.options.length > 0) {
            listbox.remove(listbox.options.length - 1);
        }
    });

    document.getElementById('copy-button').addEventListener('click', function () {
        const options = Array.from(listbox.options).map(option => option.text).join('\n');
        outputText.value = options;
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
        textarea.setSelectionRange(0, 999999999999999); // Para móviles

        // Intentar copiar el contenido al portapapeles
        try {
            document.execCommand('copy');
            console.log('Contenido copiado al portapapeles');
        } catch (err) {
            console.error('No se pudo copiar el contenido: ', err);
        }
    } else {
        console.error('Textarea con ID ' + idTextarea + ' no encontrado');
    }
}
