using System;
using System.Collections.Generic;
using System.Text;

namespace Metodos_para_el_examen.pra_empleado
{
    public interface Imodel<T>
    {

        void Create(T t);//para crear arreglo//
        int Update(T t);//para actualizar//
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        bool Delete(T t);//para borar
        T[] FindAll();
    }
}
