const Customers = [
    { id: 1, name: "Elemento 1", Date: "2022-01-01" },
    { id: 2, name: "Elemento 2", Date: "2022-01-02" },
    { id: 3, name: "Elemento 3", Date: "2022-01-03" },
];

const lista = document.getElementById("lista");

for (let i = 0; i < elementos.length; i++) {
    const elemento = elementos[i];
    const li = document.createElement("li");
    li.innerHTML = `${elemento.id}: ${elemento.nombre} (registrado el ${elemento.fechaRegistro})`;
    lista.appendChild(li);
}
