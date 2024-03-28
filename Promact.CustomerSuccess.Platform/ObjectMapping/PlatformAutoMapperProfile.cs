using AutoMapper;
using Promact.CustomerSuccess.Platform.Entities;
using Promact.CustomerSuccess.Platform.Services.Dtos;
using Promact.CustomerSuccess.Platform.Services.Dtos.ApprovedTeams;
using Promact.CustomerSuccess.Platform.Services.Dtos.AuditHistories;
using Promact.CustomerSuccess.Platform.Services.Dtos.ClientFeedbacks;
using Promact.CustomerSuccess.Platform.Services.Dtos.EscalationMatrices;
using Promact.CustomerSuccess.Platform.Services.Dtos.MeetingMinutes;
using Promact.CustomerSuccess.Platform.Services.Dtos.PhaseMilestones;
using Promact.CustomerSuccess.Platform.Services.Dtos.Phases;
using Promact.CustomerSuccess.Platform.Services.Dtos.ProjectBudgets;
using Promact.CustomerSuccess.Platform.Services.Dtos.ProjectResources;
using Promact.CustomerSuccess.Platform.Services.Dtos.Projects;
using Promact.CustomerSuccess.Platform.Services.Dtos.ProjectUpdates;
using Promact.CustomerSuccess.Platform.Services.Dtos.RiskProfiles;
using Promact.CustomerSuccess.Platform.Services.Dtos.Sprints;
using Promact.CustomerSuccess.Platform.Services.Dtos.Stakeholders;
using Promact.CustomerSuccess.Platform.Services.Dtos.VersionHistories;

namespace Promact.CustomerSuccess.Platform.ObjectMapping;

public class PlatformAutoMapperProfile : Profile
{
    public PlatformAutoMapperProfile()
    {
        /* Create your AutoMapper object mappings here */
        CreateMap<CreateProjectDto, Project>();
        CreateMap<UpdateProjectDto, Project>();
        CreateMap<Project, ProjectDto>().ReverseMap();

        CreateMap<CreateClientFeedbackDto, ClientFeedback>();
        CreateMap<UpdateClientFeedbackDto, ClientFeedback>();
        CreateMap<ClientFeedback, ClientFeedbackDto>().ReverseMap();

        CreateMap<CreateProjectResourceDto, ProjectResource>();
        CreateMap<UpdateProjectResourceDto, ProjectResource>();
        CreateMap<ProjectResource, ProjectResourceDto>().ReverseMap();

        CreateMap<CreateProjectUpdateDto, ProjectUpdate>();
        CreateMap<UpdateProjectUpdateDto, ProjectUpdate>();
        CreateMap<ProjectUpdate, ProjectUpdateDto>().ReverseMap();

       CreateMap<CreateMeetingMinuteDto,MeetingMinute>();
        CreateMap<UpdateMeetingMinuteDto,MeetingMinute>();
        CreateMap<MeetingMinute,MeetingMinuteDto>().ReverseMap();

        CreateMap<CreateApprovedTeamDto, ApprovedTeam>();
        CreateMap<UpdateApprovedTeamDto, ApprovedTeam>();
        CreateMap<ApprovedTeam, ApprovedTeamDto>().ReverseMap();

        CreateMap<CreatePhaseDto, Phase>();
        CreateMap<UpdatePhaseDto, Phase>();
        CreateMap<Phase, PhaseDto>().ReverseMap();

        CreateMap<CreateProjectBudgetDto, ProjectBudget>();
        CreateMap<UpdateProjectBudgetDto, ProjectBudget>();
        CreateMap<ProjectBudget, ProjectBudgetDto>().ReverseMap();

        CreateMap<CreateAuditHistoryDto, AuditHistory>();
        CreateMap<UpdateAuditHistoryDto, AuditHistory>();
        CreateMap<AuditHistory, AuditHistoryDto>().ReverseMap();

        CreateMap<CreateVersionHistoryDto, VersionHistory>();
        CreateMap<UpdateVersionHistoryDto, VersionHistory>();
        CreateMap<VersionHistory, VersionHistoryDto>().ReverseMap();

        CreateMap<CreateStakeholderDto, Stakeholder>();
        CreateMap<UpdateStakeholderDto, Stakeholder>();
        CreateMap<Stakeholder, StakeholderDto>().ReverseMap();

        CreateMap<CreateRiskProfileDto, RiskProfile>();
        CreateMap<UpdateRiskProfileDto, RiskProfile>();
        CreateMap<RiskProfile, RiskProfileDto>().ReverseMap();


        CreateMap<CreateAuditHistoryDto, AuditHistory>();
        CreateMap<UpdateAuditHistoryDto, AuditHistory>();
        CreateMap<AuditHistory, AuditHistoryDto>().ReverseMap();


        CreateMap<CreateVersionHistoryDto, VersionHistory>();
        CreateMap<UpdateVersionHistoryDto, VersionHistory>();
        CreateMap<VersionHistory, VersionHistoryDto>().ReverseMap();


        CreateMap<CreateStakeholderDto, Stakeholder>();
        CreateMap<UpdateStakeholderDto, Stakeholder>();
        CreateMap<Stakeholder, StakeholderDto>().ReverseMap();
        

        CreateMap<CreateEscalationMatrixDto, EscalationMatrix>();
        CreateMap<UpdateEscalationMatrixDto, EscalationMatrix>();
        CreateMap<EscalationMatrix, EscalationMatrixDto>().ReverseMap();

        CreateMap<CreatePhaseMilestoneDto, PhaseMilestone>();
        CreateMap<UpdatePhaseMilestoneDto, PhaseMilestone>();
        CreateMap<PhaseMilestone, PhaseMilestoneDto>().ReverseMap();

        CreateMap<CreateSprintDto, Sprint>();
        CreateMap<UpdateSprintDto, Sprint>();
        CreateMap<Sprint, SprintDto>().ReverseMap();
    }

}

