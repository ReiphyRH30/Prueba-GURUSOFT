export const Resultados = ({
  numeroInicial,
  cantidadDeNumeros,
  numerosPrimos,
}) => {
  return (
    <div>
      <h2>Resultados</h2>
      <p>Número Inicial: {numeroInicial}</p>
      <p>Cantidad de Números: {cantidadDeNumeros}</p>
      <p>Números Primos:</p>
      <ul>
        {numerosPrimos.map((numero, index) => (
          <li key={index}>{numero}</li>
        ))}
      </ul>
    </div>
  );
};
