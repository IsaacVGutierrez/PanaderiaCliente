using Panaderia.BD.Data.Entidades;



namespace PanaderiaCliente.Client.Servicios
{
    public interface IHttpService
    {
     
        List<Producto> Productos { get; set; }
        List<Proveedor> Proveedores { get; set; }


        Task<HttpRespuesta<T>> Get<T>(string url);
        Task<HttpRespuesta<object>> Post<T>(string url, T enviar);
        Task<HttpRespuesta<object>> Put<T>(string url, T enviar);
        Task<HttpRespuesta<object>> Delete(string url);
    }
}