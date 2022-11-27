using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_panel.Helpers.Web
{
    public  interface IHttpHelper
    {
       /// <summary>
       /// Metodo Que permite realizar una consulta GET
       /// </summary>
       /// <param name="url"></param>
       /// <returns></returns>
        Task<string> HttpGet(string url);

        /// <summary>
        /// Metodo que permite serializar un jeosn a objeto dentro de una lista
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="response"></param>
        /// <returns></returns>
        List<T> ResponSerializableList<T>(string response);
        /// <summary>
        /// Metodo que permite serializar un json a un objeto
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="response"></param>
        /// <returns></returns>
        T ResponSerializableObject<T>(string response);

        /// <summary>
        /// Metodo que permite realizar consultas POST a servicios web
        /// Serializa objetos a Json y los deserealiza a Objeto
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="view"></param>
        /// <param name="method"></param>
        /// <returns></returns>
        T Post<T>(string url, T view, string method = "POST");
    }
}
