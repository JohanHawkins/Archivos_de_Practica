const readline = require("readline");

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

const inventario = {
  "Manzanas": 10,
  "Peras": 5,
  "Bananos": 12
};

// Función para preguntar usando Promesas
function preguntar(texto) {
  return new Promise(resolve => {
    rl.question(texto, (respuesta) => resolve(respuesta));
  });
}

async function main() {
  let opcion = 0;

  while (opcion != 2) {
    opcion = parseInt(await preguntar("Presiona:\n1. Agregar unidades\n2. Salir\n> "));

    if (opcion === 1) {
      const producto = await preguntar("Producto (Manzanas, Peras, Bananos): ");

      if (inventario.hasOwnProperty(producto)) {

        // Validar que no ingresen negativos o ceros
        let unidades = -1;
        while (isNaN(unidades) || unidades <= 0) {
          unidades = parseInt(await preguntar(`¿Cuántas unidades agregar a ${producto}? `));

          if (isNaN(unidades) || unidades <= 0) {
            console.log("\nError: Debes ingresar un número mayor a 0.\n");
          }
        }

        inventario[producto] += unidades;
        console.log(`\n${producto} ahora tiene ${inventario[producto]} unidades.\n`);

      } else {
        console.log("\nEl producto no existe en el inventario.\n");
      }

    } else if (opcion === 2) {
      console.log("\nSaliendo del programa...");
    } else {
      console.log("\nOpción no válida.\n");
    }
  }

  rl.close();
}

main();
