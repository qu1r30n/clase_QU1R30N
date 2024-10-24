const listaDeProductos = document.getElementById('listaDeProductos');

let productos = [];


document.addEventListener("DOMContentLoaded", function() 
{
  for (let i = 0; i < productos_a_mover.length; i++) 
  {
    agregarProducto(productos_a_mover[i].id +"|"+productos_a_mover[i].nombre+"|"+productos_a_mover[i].imagen+"|"+productos_a_mover[i].cantidad+"|"+productos_a_mover[i].precio+"|"+productos_a_mover[i].extra);
  }  
  renderizarProductos(productos);
});

function actualizarCantidad(idProducto, cantidad) 
{
  const producto = buscarProductoPorId(productos, idProducto);
  if (producto) 
  {
    let es_mayor_a_cero=producto.cantidad+cantidad;
    if (es_mayor_a_cero>=0) 
    {
      producto.cantidad += cantidad;
      producto.total = producto.cantidad * producto.precio; // Actualizar el precio total del producto
      limpiarListaDeProductos();
      fila = document.createElement('div');
      renderizarProductos(productos);
      actualizarPrecioTotal(); // Llamar a la función para actualizar el precio total
    }
    else
    {
      producto.cantidad = 0;
      producto.total = producto.cantidad * producto.precio; // Actualizar el precio total del producto
      limpiarListaDeProductos();
      fila = document.createElement('div');
      renderizarProductos(productos);
      actualizarPrecioTotal(); // Llamar a la función para actualizar el precio total
    }
  }
}

function buscarProductoPorId(productos, idProducto) 
{
  for (let i = 0; i < productos.length; i++) 
  {
    if (productos[i].id === idProducto) 
    {
      return productos[i];
    }
  }
  return null; // Devolver null si el producto no se encuentra
}

function limpiarListaDeProductos() 
{
  while (listaDeProductos.firstChild) 
  {
    listaDeProductos.removeChild(listaDeProductos.firstChild);
  }
  fila=null
  fila = document.createElement('div');

}

function renderizarProductos(productos) 
{
  listaDeProductos.innerHTML = '';
  j = 0;
  for (let i = 0; i < productos.length; i++) 
  {
    const { id, nombre, imagen, cantidad, precio, extra, total } = productos[i];
    if (j > 1) 
    {
      renderizarProducto(id, nombre, imagen, cantidad, precio, extra, total, true);
      j = 0;
    } 
    else 
    {
      renderizarProducto(id, nombre, imagen, cantidad, precio, extra, total, false);
    }
    j++;
  }
}

let fila = document.createElement('div');
function renderizarProducto(id, nombre, imagen, cantidad, precio, extra, total, hacerNuevoDiv = false) {
  fila.style.display = 'flex';
  if (hacerNuevoDiv) {
      fila = document.createElement('div');
      fila.style.display = 'flex';
  }

  const productoDiv = document.createElement('div');
  productoDiv.classList.add('producto');

  const img = document.createElement('img');
  img.src = imagen;
  img.addEventListener('click', () => {
      img.classList.toggle('enlarged');
  });
  productoDiv.appendChild(img);

  const nombreElemento = document.createElement('p');
  nombreElemento.textContent = nombre;
  productoDiv.appendChild(nombreElemento);

  const precioElemento = document.createElement('p');
  precioElemento.textContent = `Precio: $${precio.toFixed(2)}`;
  productoDiv.appendChild(precioElemento);

  const botonMenos = document.createElement('button');
  botonMenos.textContent = '-';
  botonMenos.style.height = '40px';
  botonMenos.style.width = '80px';
  botonMenos.addEventListener('click', () => actualizarCantidad(id, -1));
  productoDiv.appendChild(botonMenos);

  const inputCantidad = document.createElement('input');
  inputCantidad.type = 'number';
  inputCantidad.value = cantidad;
  inputCantidad.addEventListener('input', (event) => {
      const nuevaCantidad = parseInt(event.target.value);
      const producto = buscarProductoPorId(productos, id);
      if (!isNaN(nuevaCantidad) && producto) {
          let res = producto.cantidad + nuevaCantidad;
          if (res > 0) {
              producto.cantidad = nuevaCantidad;
              producto.total = nuevaCantidad * precio;
              actualizarPrecioTotal();
          }
      }
  });
  productoDiv.appendChild(inputCantidad);

  const botonMas = document.createElement('button');
  botonMas.textContent = '+';
  botonMas.style.height = '40px';
  botonMas.style.width = '80px';
  botonMas.addEventListener('click', () => actualizarCantidad(id, 1));
  productoDiv.appendChild(botonMas);

  const inputextra = document.createElement('input');
  inputextra.type = 'text';
  inputextra.value = extra;
  inputextra.addEventListener('input', (event) => {
      const nuevoValorExtra = event.target.value;
      const producto = buscarProductoPorId(productos, id);
      if (producto) {
          producto.extra = nuevoValorExtra;
      }
  });
  productoDiv.appendChild(inputextra);

  const totalElemento = document.createElement('p');
  totalElemento.textContent = `Total: $${total.toFixed(2)}`;
  productoDiv.appendChild(totalElemento);

  fila.appendChild(productoDiv);
  listaDeProductos.appendChild(fila);
}


function agregarProducto(datos) 
{
  const datosSeparados = datos.split('|');
  
  const nuevoProducto = {
    id: parseInt(datosSeparados[0]),
    nombre: datosSeparados[1],
    imagen: datosSeparados[2],
    cantidad: parseInt(datosSeparados[3]),
    precio: parseFloat(datosSeparados[4]),
    extra: datosSeparados[5],
    total: 0 // Inicializar el precio total en 0
  };

  productos.push(nuevoProducto);
}

function procesarPedido() {
  // Recopilar la información de los productos en el formato requerido
  let textoPedido = '';
  let textoDescripcion='';
  let precioTotalPedido = 0; // Inicializar el precio total del pedido
  for (let i = 0; i < productos.length; i++) 
  {
      const { id, nombre, cantidad, extra, total } = productos[i];
      if (cantidad > 0) 
      {
          textoPedido += `${id}:${cantidad}∆`;
          textoDescripcion += `${id}|${nombre}|${cantidad}|${total}\n`;
          if (extra) {
              textoPedido += `extra: ${extra}∆`;
              textoDescripcion += `extra: ${extra}\n`;
          }
          precioTotalPedido += total; // Sumar el precio total del producto al precio total del pedido
      }
  }
  
  var elementoUbicacion = document.getElementById("ubicacion");
  var textoUbicacion = elementoUbicacion.value;
  if (textoUbicacion!="")
  {
      textoPedido=textoPedido+"ubi:"+textoUbicacion;
  } 
  
  // Mostrar el texto del pedido y el precio total en el contenedor de contenido
  document.getElementById('contenido').innerText = textoPedido;
  document.getElementById('infoProducto').innerText = textoDescripcion;
  document.getElementById('precioTotal').innerText = `Precio Total: $${precioTotalPedido.toFixed(2)}`;
}

function copiarContenido() 
{
  var contenidoDiv = document.getElementById('contenido');
  var rangoSeleccion = document.createRange();
  rangoSeleccion.selectNode(contenidoDiv);
  window.getSelection().removeAllRanges();
  window.getSelection().addRange(rangoSeleccion);
  document.execCommand('copy');
  window.getSelection().removeAllRanges();
  alert('Contenido copiado al portapapeles.');
}

document.addEventListener("DOMContentLoaded", function() {
  // Otro código de inicialización aquí...

  const buscarProducto = document.getElementById('buscarProducto');
  const buscarPorNombre = document.getElementById('buscarPorNombre');
  const ingresarCantidad = document.getElementById('ingresarCantidad'); // Nuevo campo de entrada para ingresar el ID y la cantidad

  buscarProducto.addEventListener('input', function(event) {
    limpiarListaDeProductos()

    const idBuscado = parseInt(event.target.value);
    if (!isNaN(idBuscado)) {
      const productosFiltrados = productos.filter(producto => producto.id === idBuscado);
      renderizarProductos(productosFiltrados);
    } else {
      renderizarProductos(productos);
    }
  });

  buscarPorNombre.addEventListener('input', function(event) {
    limpiarListaDeProductos();

    const nombreBuscado = event.target.value.toLowerCase(); // Convertir el nombre buscado a minúsculas
    const productosFiltrados = productos.filter(producto => producto.nombre.toLowerCase().includes(nombreBuscado));
    renderizarProductos(productosFiltrados);
  });

  // Agregar evento al presionar la tecla "Enter" en el campo de ingresar cantidad
  ingresarCantidad.addEventListener('keydown', function(event) {
    if (event.key === 'Enter') {
      const idProducto = parseInt(ingresarCantidad.value);
      if (!isNaN(idProducto)) {
        const productoEncontrado = buscarProductoPorId(productos, idProducto);
        if (productoEncontrado) {
          const nombreProducto = productoEncontrado.nombre;
          const cantidadProducto = productoEncontrado.cantidad + 1; // Incrementar la cantidad
          alert(`Producto: ${nombreProducto}, Cantidad: ${cantidadProducto}`);
          actualizarCantidad(idProducto, 1); // Incrementar la cantidad del producto correspondiente
          ingresarCantidad.value = ''; // Limpiar el campo de entrada después de incrementar la cantidad
        } else {
          alert('El producto no está en la lista.'); // Mensaje si el producto no está en la lista
          ingresarCantidad.value = ''; // Limpiar el campo de entrada si el producto no está en la lista
        }
      }
    }
  });
});

//localisacion------------------------------------------------------------------------------------------------
async function obtenerUbicacion() {
  if (navigator.geolocation) {
      try {
          const position = await new Promise((resolve, reject) => {
              navigator.geolocation.getCurrentPosition(resolve, reject);
          });
          return `${position.coords.latitude}, ${position.coords.longitude}`;
      } catch (error) {
          console.error("Error al obtener la ubicación:", error);
          throw error;
      }
  } else {
      console.error("La geolocalización no es compatible en este navegador.");
      throw new Error("La geolocalización no es compatible en este navegador.");
  }
}

async function obtenerYMostrarUbicacion() {
  try {
      const ubicacion = await obtenerUbicacion();
      document.getElementById("ubicacion").value = `${ubicacion}`;
  } catch (error) {
      document.getElementById("ubicacion").value = "Error al obtener la ubicación";
  }
}

document.getElementById("obtenerUbicacionBtn").addEventListener("click", obtenerYMostrarUbicacion);


//fin-localisacion------------------------------------------------------------------------------------------------
function actualizarPrecioTotal() {
  let precioTotal = 0;
  productos.forEach(producto => {
    precioTotal += producto.total;
  });
  document.getElementById('precioTotal').innerText = `Precio Total: $${precioTotal.toFixed(2)}`;
}