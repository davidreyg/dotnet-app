namespace DE.Application.DTOs.Response;

public record class AttentionMetricsResponse(
    int TotalAttentions,
    int Emergencies,
    int Hospitalized,
    int Attended
);
