namespace Dsw2025Ej14.Api.Data
{
    public class SingletonPersistenciaEnMemoria
    {
        private PersistenciaEnMemoria _persistenciaEnMemoria;


        public PersistenciaEnMemoria GetInstance(PersistenciaEnMemoria persistenciaEnMemoria) {

            if (_persistenciaEnMemoria==null) {
                
                _persistenciaEnMemoria = persistenciaEnMemoria;
            
            
            }
            
            return _persistenciaEnMemoria;


        }

    }
}
