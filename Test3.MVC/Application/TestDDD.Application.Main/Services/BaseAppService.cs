

using System;
using System.Collections.Generic;
using TestDDD.Application.Main.Interfaces;
using TestDDD.Domain.Entities;
using TestDDD.Domain.Interfaces.Services;

namespace TestDDD.Application.Main.Services
{
    public class BaseAppService<TEntity> : IDisposable, IBaseAppService<TEntity> where TEntity : class
    {
        //Declaración de variables globales
        private readonly IBaseService<TEntity> baseService;

 
        public BaseAppService(IBaseService<TEntity> baseService)
        {
            this.baseService = baseService;
        }

        
        public StatusResponse add(TEntity entity)
        {
            return this.baseService.add(entity);
        }//Fin del método

        /**
         * <summary>Método que permite eliminar una entidad</summary>
         * <param name="id">Corresponde al identificador de la entidad que se desea eliminar</param>
         */
        public void delete(int id)
        {
            this.baseService.delete(id);
        }//Fin del método

        public void Dispose()
        {
            this.baseService.Dispose();
        }//Fin del método

        /**
         * <summary>Método que permite obtener todos los registros pertenecientes a esa entidad</summary>
         * <returns>Todos los objetos de ese tipo de entidad</returns>
         */
        public IEnumerable<TEntity> getAll()
        {
            return this.baseService.getAll();
        }//Fin del método

        /**
         * <summary>Método que permite obtener la información correspondiente a la entidad solicitada</summary>
         * <param name="id">Corresponde al identificador de la entidad que se desea obtener</param>
         * <returns>La información de la correspondiente entidad</returns>
         */
        public TEntity getById(int id)
        {
            return this.baseService.getById(id);
        }//Fin del método

        /**
         * <summary>Método que permite actualizar la información una entidad</summary>
         * <param name="entity">Corresponde a la entidad que se desea modificar</param>
         */
        public void modify(TEntity entity)
        {
            this.baseService.modify(entity);
        }//Fin del método
    }//Fin de la clase BaseAppService
}
