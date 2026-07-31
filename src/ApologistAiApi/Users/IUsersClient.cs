namespace ApologistAiApi;

public partial interface IUsersClient
{
    /// <summary>
    /// Returns a paginated list of users for the agent's team, with applied tags expanded as { id, name } and the persisted responder id.
    /// </summary>
    WithRawResponseTask<ListUsersResponse> ListUsersAsync(
        ListUsersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a paginated list of user flag definitions for the agent's team (all columns from user_flags), ordered by id ascending.
    /// </summary>
    WithRawResponseTask<ListUserFlagsResponse> ListUserFlagsAsync(
        ListUserFlagsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a single user by external id or internal id, with expanded tags and the persisted responder for the agent.
    /// </summary>
    WithRawResponseTask<GetUserResponse> GetUserAsync(
        GetUserRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates a user's external_id and/or tags and upserts the persisted responder for the agent. Only provided fields are changed.
    /// </summary>
    WithRawResponseTask<UpdateUserResponse> UpdateUserAsync(
        UserUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
