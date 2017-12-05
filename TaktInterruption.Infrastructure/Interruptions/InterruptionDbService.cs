using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using TaktInterruption.Common.Settings;
using TaktInterruption.Core.Entities;
using TaktInterruption.Core.Interfaces;

namespace TaktInterruption.Infrastructure.Interruptions
{
    public class InterruptionDbService : IInterruptionDbService
    {
        private readonly IOptions<ConfigurationSettings> _configurationSettings;

        public InterruptionDbService(IOptions<ConfigurationSettings> configurationSettings)
        {
            _configurationSettings = configurationSettings ?? throw new ArgumentNullException(nameof(configurationSettings));
        }

        public Interruption GetInterruption(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InterruptionArea> GetInterruptionAreas()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InterruptionCategory> GetInterruptionCategories()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Interruption> GetInterruptions()
        {
            List<Interruption> interruptions = new List<Interruption>();

            try
            {
                using (SqlConnection connection = new SqlConnection(_configurationSettings.Value.DefaultConnection))
                using (SqlCommand command = new SqlCommand("GetInterruptions", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    connection.Open();

                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            int id = reader.GetOrdinal("Id");
                            int interruptionAreaId = reader.GetOrdinal("InterruptionAreaId");
                            int interruptionAreaName = reader.GetOrdinal("InterruptionAreaName");
                            int interruptionCategoryId = reader.GetOrdinal("InterruptionCategoryId");
                            int interruptionCategoryName = reader.GetOrdinal("InterruptionCategoryName");
                            int createdBy = reader.GetOrdinal("CreatedBy");
                            int description = reader.GetOrdinal("Description");
                            int dateTimeCreated = reader.GetOrdinal("DateTimeCreated");

                            while (reader.Read())
                            {
                                var interruption = new Interruption(
                                    reader.GetInt32(id),
                                    reader.GetString(description),
                                    reader.GetString(createdBy),
                                    new InterruptionArea(reader.GetInt32(interruptionAreaId), reader.GetString(interruptionAreaName), true),
                                    new InterruptionCategory(reader.GetInt32(interruptionCategoryId), reader.GetString(interruptionCategoryName), true),
                                    reader.GetDateTime(dateTimeCreated)
                                    );

                                interruptions.Add(interruption);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return interruptions;
        }

        public void SaveInterruption(Interruption interruption)
        {
            throw new NotImplementedException();
        }

        public void UpdateInterruption(Interruption interruption)
        {
            throw new NotImplementedException();
        }
    }
}
