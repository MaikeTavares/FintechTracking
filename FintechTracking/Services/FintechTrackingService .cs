using FintechTracking.DTO;
using FintechTracking.Entites;


namespace FintechTracking.Services
{
    public class FintechTrackingService
    {
        public void StartOnboardingTracking(TrackingDTO trackingDto)
        {
            FintechOnboardingTracking entity = MapDtoToEntity(trackingDto);
            entity.Date = DateTime.Now;

            Console.WriteLine("Iniciando rastreamento...");
            Console.WriteLine($"Data: {entity.Date}, Etapa: {entity.Step}, Documento: {entity.Document}");
        }

        public void UpdateOnboardingTracking(TrackingDTO trackingDto)
        {
            FintechOnboardingTracking entity = MapDtoToEntity(trackingDto);
            entity.Date = DateTime.Now;

            Console.WriteLine("Atualizando rastreamento...");
            Console.WriteLine($"Data: {entity.Date}, Etapa: {entity.Step}, Documento: {entity.Document}");
        }

        private FintechOnboardingTracking MapDtoToEntity(TrackingDTO dto)
        {
            return new FintechOnboardingTracking
            {
                Step = dto.Step,
                Document = dto.Document,
            };
        }

    }
}
