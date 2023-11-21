const url = "https://localhost:5028/api/request";


export const obtenerCalculo = async (i, n, nombre) => {


    try {
        const response = await fetch(`${url}/${i}/${n}/${nombre}`);
        if(!response.ok){
            throw new Error("Error: ",response.status);
        }

        const data = await response.json();
        return data;
    } catch (error) {
        console.log(error)
        throw error;
    }

};