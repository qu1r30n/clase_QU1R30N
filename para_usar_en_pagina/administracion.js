// Seleccionamos los elementos
const heroSection = document.querySelector('.hero');
const button = document.getElementById('changeStyleBtn');

// Función para transformar el estilo
function transformStyle() {
    heroSection.classList.toggle('transformed');
}

// Añadimos el evento de clic
button.addEventListener('click', transformStyle);
