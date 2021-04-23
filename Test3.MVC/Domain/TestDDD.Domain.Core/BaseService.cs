using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDDD.Domain.Entities;
using TestDDD.Domain.Interfaces.Repositories;
using TestDDD.Domain.Interfaces.Services;

namespace TestDDD.Domain.Core
{

    public class BaseService<TEntity> : IDisposable, IBaseService<TEntity> where TEntity : class
    {
        //Declaración de variables globales
        private readonly IBaseRepository<TEntity> baseRepository;


        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            this.baseRepository = baseRepository;
        }//Fin del método

        
        public StatusResponse add(TEntity entity)
        {
            

            return this.baseRepository.add(entity);
        }//Fin del método

        
        public void delete(int id)
        {
            this.baseRepository.delete(id);
        }//Fin del método

        public void Dispose()
        {
            this.baseRepository.Dispose();
        }//Fin del método

    
        public IEnumerable<TEntity> getAll()
        {
            return this.baseRepository.getAll();
        }//Fin del método

   
        public TEntity getById(int id)
        {
            return this.baseRepository.getById(id);
        }//Fin del método

      
        public void modify(TEntity entity)
        {
            this.baseRepository.modify(entity);
        }//Fin del método
    }//Fin de la clase BaseService
}
