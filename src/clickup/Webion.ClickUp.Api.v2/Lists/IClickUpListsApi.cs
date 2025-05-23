using Refit;
using Webion.ClickUp.Api.v2.Lists.Dtos;

namespace Webion.ClickUp.Api.v2.Lists;

public interface IClickUpListsApi
{
    [Get("/v2/folder/{folderId}/list")]
    Task<GetAllListsResponse> GetInFolderAsync(string folderId);
    
    [Get("/v2/space/{spaceId}/list")]
    Task<GetAllListsResponse> GetNotInFolderAsync(string spaceId);
}