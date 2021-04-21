using System;
using System.Threading.Tasks;
using BlazorInputFile;

namespace ProyectoFinal.Services{
    public interface ICargarArchivo{
        Task Cargar(IFileListEntry file);
    }
}