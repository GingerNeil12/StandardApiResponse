# How to use

The following status codes and corresponding response models are:

* 200 (OK) : OkApiResponse
* 201 (Created) : CreatedApiResponse
* 400 (BadRequest) : BadRequestApiResponse
* 401 (Unauthorized) : UnauthorizedApiResponse
* 403 (Forbidden) : ForbiddenApiResponse
* 404 (NotFound) : NotFoundApiResponse
* 500 (InternalServerError) : InternalServerErrorApiResponse

The base class ApiResponse is also available to override for other Response Statuses.

There is also the ResponseMessage model with the following propeties:

* Status : int
* Payload : ApiResponse (base class)

## Responses 

The following models have the following properties:

* ApiResponse :
	* Status : int (HttpStatusCode of the Response Model)
	* Title : string (Default title of the HttpStatusCode. Can be overridden)
	* RequestDate : DateTime (DateTime of the request)
* OkApiResponse :
	* Result : object (To be set to whatever the requested resource is)
* CreatedApiResponse :
	* Id : object (to be set to whatever the created resource is)
* BadRequest :
	* Errors : object (To be set to the validation errors)
	* The model will convert a ModelStateDictionary to a Dictionary of the errors for you
