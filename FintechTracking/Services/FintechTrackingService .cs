using FintechTracking.DTO;
using FintechTracking.Entites;
using FintechTrackingDb;
using Microsoft.EntityFrameworkCore;


namespace FintechTracking.Services
{
    public class FintechTrackingService
    {
        private readonly DataContext _context;

        public FintechTrackingService(DataContext context)
        {
            _context = context;
        }
        public void StartOnboardingTracking(TrackingDTO trackingDto)
        {
            FintechOnboardingTracking entity = MapDtoToEntity(trackingDto);
            entity.Date = DateTime.Now;

            Console.WriteLine("Iniciando rastreamento...");
            Console.WriteLine($"Data: {entity.Date}, Etapa: {entity.Step}, Documento: {entity.Document}");

            _context.FintechOnboardingTrackings.Add(entity);
            _context.SaveChanges();


        }

        public void UpdateOnboardingTracking(TrackingDTO trackingDto)
        {
            FintechOnboardingTracking entity = MapDtoToEntity(trackingDto);
            entity.Date = DateTime.Now;


            Console.WriteLine("Atualizando rastreamento...");
            Console.WriteLine($"Data: {entity.Date}, Etapa: {entity.Step}, Documento: {entity.Document}");

            _context.FintechOnboardingTrackings.Add(entity);
            _context.SaveChanges();


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
