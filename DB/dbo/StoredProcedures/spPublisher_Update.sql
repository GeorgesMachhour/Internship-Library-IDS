CREATE PROCEDURE [dbo].[spPublisher_Update]
	@PublisherId int,
	@PublisherName nvarchar(100),
	@PublisherEmail NVARCHAR(100),
    @PublisherPhone BIGINT
AS
begin
	update dbo.[Publisher]
	set PublisherName = @PublisherName,
	PublisherEmail = @PublisherEmail,
    PublisherPhone = @PublisherPhone
	where PublisherId = @PublisherId;
end
