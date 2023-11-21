import { useState } from "react";
import { Error } from "./components/Error";
import { Resultados } from "./components/Resultados";
import { obtenerCalculo } from "./helpers/CalcularHelpers";

export const App = () => {
  const [usuario, setUsuario] = useState("");
  const [numeroInicio, setNumeroInicio] = useState(0);
  const [cantidadDeNumeros, setCantidadDeNumeros] = useState(0);
  const [calculo, setCalculo] = useState([]);

  const [formularioEnviado, setFormularioEnviado] = useState(false);

  const enviarFormulario = async (event) => {
    setFormularioEnviado(true);

    event.preventDefault();

    if ([numeroInicio, cantidadDeNumeros].some((numero) => numero <= 0)) return;

    if (usuario.length == 0) return;

    const data = await obtenerCalculo(numeroInicio, cantidadDeNumeros, usuario);
    setCalculo(data);
  };

  return (
    <>
      <h1 className="text-capitalize text-center m-3 border">
        Consulta de numeros primos
      </h1>

      <form onSubmit={enviarFormulario}>
        <div className="d-flex justify-content-center row">
          <div className="col-3">
            <div className="mb-3">
              <input
                className="form-control"
                type="text"
                placeholder="Ingrese su usuario"
                onChange={(event) => setUsuario(event.target.value)}
              />
              {usuario.length == 0 && formularioEnviado ? (
                <Error mensaje={"El campo usuario no puede ir vacio"} />
              ) : (
                ""
              )}
            </div>
          </div>
          <div className="col-3">
            <div className="mb-3">
              <input
                className="form-control"
                type="number"
                placeholder="Ingrese el numero de inicio"
                onChange={(event) => setNumeroInicio(event.target.value)}
              />
              {numeroInicio <= 0 && formularioEnviado ? (
                <Error
                  mensaje={"El campo numero de inicio no puede ser menor a 1"}
                />
              ) : (
                ""
              )}
            </div>
          </div>

          <div className="col-3">
            <div className="mb-3">
              <input
                className="form-control"
                type="number"
                placeholder="Ingrese la cantidad de numeros"
                onChange={(event) => setCantidadDeNumeros(event.target.value)}
              />
              {cantidadDeNumeros <= 0 && formularioEnviado ? (
                <Error
                  mensaje={
                    "El campo cantidad de numeros no puede ser menor a 1"
                  }
                />
              ) : (
                ""
              )}
            </div>
          </div>
        </div>

        <div className="d-flex justify-content-center">
          <button type="submit" className="btn btn-primary mr-3">
            Calcular
          </button>
          <div style={{ width: "10px" }}></div>
          {""}
          <button className="btn btn-danger " type="reset">
            Limpiar
          </button>
        </div>

        <div className="d-flex justify-content-center">
          {formularioEnviado && calculo.length ? (
            <Resultados
              numeroInicial={numeroInicio}
              cantidadDeNumeros={cantidadDeNumeros}
              numerosPrimos={calculo}
            />
          ) : (
            ""
          )}
        </div>
      </form>
    </>
  );
};
