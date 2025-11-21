<!-- Generator: Widdershins v4.0.1 -->

<h1 id="admin-api-documentation">Admin API Documentation v2</h1>

> Scroll down for code samples, example requests and responses. Select a language for code samples from the tabs above or the mobile navigation menu.

The Ed-Fi Admin API is a REST API-based administrative interface for managing vendors, applications, client credentials, and authorization rules for accessing an Ed-Fi API.

# Authentication

- oAuth2 authentication. 

    - Flow: clientCredentials

    - Token URL = [https://localhost/connect/token](https://localhost/connect/token)

|Scope|Scope Description|
|---|---|
|edfi_admin_api/full_access|Full access to the Admin API|

<h1 id="admin-api-documentation-tenants">Tenants</h1>

## get__v2_tenants

`GET /v2/tenants`

<h3 id="get__v2_tenants-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## get__v2_tenants_{tenantName}

`GET /v2/tenants/{tenantName}`

<h3 id="get__v2_tenants_{tenantname}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|tenantName|path|string|true|none|

<h3 id="get__v2_tenants_{tenantname}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

<h1 id="admin-api-documentation-resourceclaims">ResourceClaims</h1>

## get__v2_resourceClaims

`GET /v2/resourceClaims`

<h3 id="get__v2_resourceclaims-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|offset|query|integer(int32)|false|Indicates how many items should be skipped before returning results.|
|limit|query|integer(int32)|false|Indicates the maximum number of items that should be returned in the results.|
|orderBy|query|string|false|Indicates the property name by which the results will be sorted.|
|direction|query|string|false|Indicates whether the result should be sorted in descending order (DESC) or ascending order (ASC).|
|id|query|integer(int32)|false|Resource Claim Id|
|name|query|string|false|Resource Claim Name|

#### Enumerated Values

|Parameter|Value|
|---|---|
|direction|Ascending|
|direction|Descending|

> Example responses

> 200 Response

```json
[
  {
    "id": 0,
    "name": "string",
    "parentId": 0,
    "parentName": "string",
    "children": [
      {}
    ]
  }
]
```

<h3 id="get__v2_resourceclaims-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|Inline|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<h3 id="get__v2_resourceclaims-responseschema">Response Schema</h3>

Status Code **200**

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|[[resourceClaimModel](#schemaresourceclaimmodel)]|false|none|none|
|» id|integer(int32)|false|none|none|
|» name|string¦null|false|none|none|
|» parentId|integer(int32)¦null|false|none|none|
|» parentName|string¦null|false|none|none|
|» children|[[resourceClaimModel](#schemaresourceclaimmodel)]¦null|false|none|none|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## get__v2_resourceClaims_{id}

`GET /v2/resourceClaims/{id}`

<h3 id="get__v2_resourceclaims_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

> Example responses

> 200 Response

```json
{
  "id": 0,
  "name": "string",
  "parentId": 0,
  "parentName": "string",
  "children": [
    {
      "id": 0,
      "name": "string",
      "parentId": 0,
      "parentName": "string",
      "children": []
    }
  ]
}
```

<h3 id="get__v2_resourceclaims_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[resourceClaimModel](#schemaresourceclaimmodel)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

<h1 id="admin-api-documentation-resourceclaimactions">ResourceClaimActions</h1>

## get__v2_resourceClaimActions

`GET /v2/resourceClaimActions`

<h3 id="get__v2_resourceclaimactions-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|offset|query|integer(int32)|false|Indicates how many items should be skipped before returning results.|
|limit|query|integer(int32)|false|Indicates the maximum number of items that should be returned in the results.|
|orderBy|query|string|false|Indicates the property name by which the results will be sorted.|
|direction|query|string|false|Indicates whether the result should be sorted in descending order (DESC) or ascending order (ASC).|
|resourceName|query|string|false|none|

#### Enumerated Values

|Parameter|Value|
|---|---|
|direction|Ascending|
|direction|Descending|

> Example responses

> 200 Response

```json
[
  {
    "resourceClaimId": 0,
    "resourceName": "string",
    "claimName": "string",
    "actions": [
      {
        "name": "string"
      }
    ]
  }
]
```

<h3 id="get__v2_resourceclaimactions-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|Inline|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<h3 id="get__v2_resourceclaimactions-responseschema">Response Schema</h3>

Status Code **200**

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|[[resourceClaimActionModel](#schemaresourceclaimactionmodel)]|false|none|none|
|» resourceClaimId|integer(int32)|false|none|none|
|» resourceName|string¦null|false|none|none|
|» claimName|string¦null|false|none|none|
|» actions|[[actionForResourceClaimModel](#schemaactionforresourceclaimmodel)]¦null|false|none|none|
|»» name|string¦null|false|none|none|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

<h1 id="admin-api-documentation-resourceclaimactionauthstrategies">ResourceClaimActionAuthStrategies</h1>

## get__v2_resourceClaimActionAuthStrategies

`GET /v2/resourceClaimActionAuthStrategies`

<h3 id="get__v2_resourceclaimactionauthstrategies-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|offset|query|integer(int32)|false|Indicates how many items should be skipped before returning results.|
|limit|query|integer(int32)|false|Indicates the maximum number of items that should be returned in the results.|
|orderBy|query|string|false|Indicates the property name by which the results will be sorted.|
|direction|query|string|false|Indicates whether the result should be sorted in descending order (DESC) or ascending order (ASC).|
|resourceName|query|string|false|none|

#### Enumerated Values

|Parameter|Value|
|---|---|
|direction|Ascending|
|direction|Descending|

> Example responses

> 200 Response

```json
[
  {
    "resourceClaimId": 0,
    "resourceName": "string",
    "claimName": "string",
    "authorizationStrategiesForActions": [
      {
        "actionId": 0,
        "actionName": "string",
        "authorizationStrategies": [
          {
            "authStrategyId": 0,
            "authStrategyName": "string"
          }
        ]
      }
    ]
  }
]
```

<h3 id="get__v2_resourceclaimactionauthstrategies-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|Inline|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<h3 id="get__v2_resourceclaimactionauthstrategies-responseschema">Response Schema</h3>

Status Code **200**

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|[[resourceClaimActionAuthStrategyModel](#schemaresourceclaimactionauthstrategymodel)]|false|none|none|
|» resourceClaimId|integer(int32)|false|none|none|
|» resourceName|string¦null|false|none|none|
|» claimName|string¦null|false|none|none|
|» authorizationStrategiesForActions|[[actionWithAuthorizationStrategy](#schemaactionwithauthorizationstrategy)]¦null|false|none|none|
|»» actionId|integer(int32)|false|none|none|
|»» actionName|string¦null|false|none|none|
|»» authorizationStrategies|[[authorizationStrategyModelForAction](#schemaauthorizationstrategymodelforaction)]¦null|false|none|none|
|»»» authStrategyId|integer(int32)|false|none|none|
|»»» authStrategyName|string¦null|false|none|none|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

<h1 id="admin-api-documentation-vendors">Vendors</h1>

## get__v2_vendors

`GET /v2/vendors`

<h3 id="get__v2_vendors-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|offset|query|integer(int32)|false|Indicates how many items should be skipped before returning results.|
|limit|query|integer(int32)|false|Indicates the maximum number of items that should be returned in the results.|
|orderBy|query|string|false|Indicates the property name by which the results will be sorted.|
|direction|query|string|false|Indicates whether the result should be sorted in descending order (DESC) or ascending order (ASC).|
|id|query|integer(int32)|false|Vendor/ company id|
|company|query|string|false|Vendor/ company name|
|namespacePrefixes|query|string|false|Namespace prefix for the vendor. Multiple namespace prefixes can be provided as comma separated list if required.|
|contactName|query|string|false|Vendor contact name|
|contactEmailAddress|query|string|false|Vendor contact email id|

#### Enumerated Values

|Parameter|Value|
|---|---|
|direction|Ascending|
|direction|Descending|

> Example responses

> 200 Response

```json
[
  {
    "id": 0,
    "company": "string",
    "namespacePrefixes": "string",
    "contactName": "string",
    "contactEmailAddress": "string"
  }
]
```

<h3 id="get__v2_vendors-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|Inline|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<h3 id="get__v2_vendors-responseschema">Response Schema</h3>

Status Code **200**

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|[[vendorModel](#schemavendormodel)]|false|none|none|
|» id|integer(int32)¦null|false|none|none|
|» company|string¦null|false|none|none|
|» namespacePrefixes|string¦null|false|none|none|
|» contactName|string¦null|false|none|none|
|» contactEmailAddress|string¦null|false|none|none|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## post__v2_vendors

`POST /v2/vendors`

> Body parameter

```json
{
  "company": "string",
  "namespacePrefixes": "string",
  "contactName": "string",
  "contactEmailAddress": "string"
}
```

<h3 id="post__v2_vendors-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[addVendorRequest](#schemaaddvendorrequest)|true|none|

<h3 id="post__v2_vendors-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## get__v2_vendors_{id}

`GET /v2/vendors/{id}`

<h3 id="get__v2_vendors_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

> Example responses

> 200 Response

```json
{
  "id": 0,
  "company": "string",
  "namespacePrefixes": "string",
  "contactName": "string",
  "contactEmailAddress": "string"
}
```

<h3 id="get__v2_vendors_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[vendorModel](#schemavendormodel)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## put__v2_vendors_{id}

`PUT /v2/vendors/{id}`

> Body parameter

```json
{
  "company": "string",
  "namespacePrefixes": "string",
  "contactName": "string",
  "contactEmailAddress": "string"
}
```

<h3 id="put__v2_vendors_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|
|body|body|[editVendorRequest](#schemaeditvendorrequest)|true|none|

<h3 id="put__v2_vendors_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## delete__v2_vendors_{id}

`DELETE /v2/vendors/{id}`

<h3 id="delete__v2_vendors_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="delete__v2_vendors_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## get__v2_vendors_{id}_applications

`GET /v2/vendors/{id}/applications`

<h3 id="get__v2_vendors_{id}_applications-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

> Example responses

> 200 Response

```json
[
  {
    "id": 0,
    "applicationName": "string",
    "claimSetName": "string",
    "educationOrganizationIds": [
      0
    ],
    "vendorId": 0,
    "profileIds": [
      0
    ],
    "odsInstanceIds": [
      0
    ],
    "enabled": true
  }
]
```

<h3 id="get__v2_vendors_{id}_applications-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|Inline|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<h3 id="get__v2_vendors_{id}_applications-responseschema">Response Schema</h3>

Status Code **200**

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|[[applicationModel](#schemaapplicationmodel)]|false|none|none|
|» id|integer(int32)|false|none|none|
|» applicationName|string¦null|false|none|none|
|» claimSetName|string¦null|false|none|none|
|» educationOrganizationIds|[integer]¦null|false|none|none|
|» vendorId|integer(int32)¦null|false|none|none|
|» profileIds|[integer]¦null|false|none|none|
|» odsInstanceIds|[integer]¦null|false|none|none|
|» enabled|boolean|false|none|none|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

<h1 id="admin-api-documentation-profiles">Profiles</h1>

## get__v2_profiles

`GET /v2/profiles`

<h3 id="get__v2_profiles-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|offset|query|integer(int32)|false|Indicates how many items should be skipped before returning results.|
|limit|query|integer(int32)|false|Indicates the maximum number of items that should be returned in the results.|
|orderBy|query|string|false|Indicates the property name by which the results will be sorted.|
|direction|query|string|false|Indicates whether the result should be sorted in descending order (DESC) or ascending order (ASC).|
|id|query|integer(int32)|false|Profile id|
|name|query|string|false|Profile name|

#### Enumerated Values

|Parameter|Value|
|---|---|
|direction|Ascending|
|direction|Descending|

> Example responses

> 200 Response

```json
[
  {
    "id": 0,
    "name": "string"
  }
]
```

<h3 id="get__v2_profiles-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|Inline|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<h3 id="get__v2_profiles-responseschema">Response Schema</h3>

Status Code **200**

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|[[profileModel](#schemaprofilemodel)]|false|none|none|
|» id|integer(int32)¦null|false|none|none|
|» name|string¦null|false|none|none|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## post__v2_profiles

`POST /v2/profiles`

> Body parameter

```json
"{\n  \"name\": \"Test-Profile\",\n  \"definition\": \"<Profile name=\\\"Test-Profile\\\"><Resource name=\\\"Resource1\\\"><ReadContentType memberSelection=\\\"IncludeOnly\\\"><Collection name=\\\"Collection1\\\" memberSelection=\\\"IncludeOnly\\\"><Property name=\\\"Property1\\\" /><Property name=\\\"Property2\\\" /></Collection></ReadContentType><WriteContentType memberSelection=\\\"IncludeOnly\\\"><Collection name=\\\"Collection2\\\" memberSelection=\\\"IncludeOnly\\\"><Property name=\\\"Property1\\\" /><Property name=\\\"Property2\\\" /></Collection></WriteContentType></Resource></Profile>\"\n}"
```

<h3 id="post__v2_profiles-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[addProfileRequest](#schemaaddprofilerequest)|true|none|

<h3 id="post__v2_profiles-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## get__v2_profiles_{id}

`GET /v2/profiles/{id}`

<h3 id="get__v2_profiles_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

> Example responses

> 200 Response

```json
{
  "id": 0,
  "name": "string",
  "definition": "string"
}
```

<h3 id="get__v2_profiles_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[profileDetailsModel](#schemaprofiledetailsmodel)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## put__v2_profiles_{id}

`PUT /v2/profiles/{id}`

> Body parameter

```json
"{\n  \"name\": \"Test-Profile\",\n  \"definition\": \"<Profile name=\\\"Test-Profile\\\"><Resource name=\\\"Resource1\\\"><ReadContentType memberSelection=\\\"IncludeOnly\\\"><Collection name=\\\"Collection1\\\" memberSelection=\\\"IncludeOnly\\\"><Property name=\\\"Property1\\\" /><Property name=\\\"Property2\\\" /></Collection></ReadContentType><WriteContentType memberSelection=\\\"IncludeOnly\\\"><Collection name=\\\"Collection2\\\" memberSelection=\\\"IncludeOnly\\\"><Property name=\\\"Property1\\\" /><Property name=\\\"Property2\\\" /></Collection></WriteContentType></Resource></Profile>\"\n}"
```

<h3 id="put__v2_profiles_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|
|body|body|[editProfileRequest](#schemaeditprofilerequest)|true|none|

<h3 id="put__v2_profiles_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## delete__v2_profiles_{id}

`DELETE /v2/profiles/{id}`

<h3 id="delete__v2_profiles_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="delete__v2_profiles_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

<h1 id="admin-api-documentation-odsinstances">OdsInstances</h1>

## get__v2_odsInstances

`GET /v2/odsInstances`

<h3 id="get__v2_odsinstances-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|offset|query|integer(int32)|false|Indicates how many items should be skipped before returning results.|
|limit|query|integer(int32)|false|Indicates the maximum number of items that should be returned in the results.|
|orderBy|query|string|false|Indicates the property name by which the results will be sorted.|
|direction|query|string|false|Indicates whether the result should be sorted in descending order (DESC) or ascending order (ASC).|
|id|query|integer(int32)|false|List of ODS instance id|
|name|query|string|false|Ods Instance name|
|instanceType|query|string|false|none|

#### Enumerated Values

|Parameter|Value|
|---|---|
|direction|Ascending|
|direction|Descending|

> Example responses

> 200 Response

```json
[
  {
    "id": 0,
    "name": "string",
    "instanceType": "string"
  }
]
```

<h3 id="get__v2_odsinstances-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|Inline|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<h3 id="get__v2_odsinstances-responseschema">Response Schema</h3>

Status Code **200**

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|[[odsInstanceModel](#schemaodsinstancemodel)]|false|none|none|
|» id|integer(int32)|false|none|none|
|» name|string¦null|false|none|none|
|» instanceType|string¦null|false|none|none|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## post__v2_odsInstances

`POST /v2/odsInstances`

> Body parameter

```json
{
  "name": "string",
  "instanceType": "string",
  "connectionString": "string"
}
```

<h3 id="post__v2_odsinstances-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[addOdsInstanceRequest](#schemaaddodsinstancerequest)|true|none|

<h3 id="post__v2_odsinstances-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## get__v2_odsInstances_{id}

`GET /v2/odsInstances/{id}`

<h3 id="get__v2_odsinstances_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

> Example responses

> 200 Response

```json
{
  "id": 0,
  "name": "string",
  "instanceType": "string",
  "odsInstanceContexts": [
    {
      "id": 0,
      "odsInstanceId": 0,
      "contextKey": "string",
      "contextValue": "string"
    }
  ],
  "odsInstanceDerivatives": [
    {
      "id": 0,
      "odsInstanceId": 0,
      "derivativeType": "string"
    }
  ]
}
```

<h3 id="get__v2_odsinstances_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[odsInstanceDetailModel](#schemaodsinstancedetailmodel)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## put__v2_odsInstances_{id}

`PUT /v2/odsInstances/{id}`

> Body parameter

```json
{
  "name": "string",
  "instanceType": "string",
  "connectionString": "string"
}
```

<h3 id="put__v2_odsinstances_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|
|body|body|[editOdsInstanceRequest](#schemaeditodsinstancerequest)|true|none|

<h3 id="put__v2_odsinstances_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## delete__v2_odsInstances_{id}

`DELETE /v2/odsInstances/{id}`

<h3 id="delete__v2_odsinstances_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="delete__v2_odsinstances_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## get__v2_odsInstances_{id}_applications

`GET /v2/odsInstances/{id}/applications`

<h3 id="get__v2_odsinstances_{id}_applications-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

> Example responses

> 200 Response

```json
[
  {
    "id": 0,
    "applicationName": "string",
    "claimSetName": "string",
    "educationOrganizationIds": [
      0
    ],
    "vendorId": 0,
    "profileIds": [
      0
    ],
    "odsInstanceIds": [
      0
    ],
    "enabled": true
  }
]
```

<h3 id="get__v2_odsinstances_{id}_applications-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|Inline|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<h3 id="get__v2_odsinstances_{id}_applications-responseschema">Response Schema</h3>

Status Code **200**

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|[[applicationModel](#schemaapplicationmodel)]|false|none|none|
|» id|integer(int32)|false|none|none|
|» applicationName|string¦null|false|none|none|
|» claimSetName|string¦null|false|none|none|
|» educationOrganizationIds|[integer]¦null|false|none|none|
|» vendorId|integer(int32)¦null|false|none|none|
|» profileIds|[integer]¦null|false|none|none|
|» odsInstanceIds|[integer]¦null|false|none|none|
|» enabled|boolean|false|none|none|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

<h1 id="admin-api-documentation-odsinstancederivatives">OdsInstanceDerivatives</h1>

## get__v2_odsInstanceDerivatives

`GET /v2/odsInstanceDerivatives`

<h3 id="get__v2_odsinstancederivatives-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|offset|query|integer(int32)|false|Indicates how many items should be skipped before returning results.|
|limit|query|integer(int32)|false|Indicates the maximum number of items that should be returned in the results.|
|orderBy|query|string|false|Indicates the property name by which the results will be sorted.|
|direction|query|string|false|Indicates whether the result should be sorted in descending order (DESC) or ascending order (ASC).|

#### Enumerated Values

|Parameter|Value|
|---|---|
|direction|Ascending|
|direction|Descending|

> Example responses

> 200 Response

```json
[
  {
    "id": 0,
    "odsInstanceId": 0,
    "derivativeType": "string"
  }
]
```

<h3 id="get__v2_odsinstancederivatives-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|Inline|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<h3 id="get__v2_odsinstancederivatives-responseschema">Response Schema</h3>

Status Code **200**

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|[[odsInstanceDerivativeModel](#schemaodsinstancederivativemodel)]|false|none|none|
|» id|integer(int32)|false|none|none|
|» odsInstanceId|integer(int32)¦null|false|none|none|
|» derivativeType|string¦null|false|none|none|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## post__v2_odsInstanceDerivatives

`POST /v2/odsInstanceDerivatives`

> Body parameter

```json
{
  "odsInstanceId": 0,
  "derivativeType": "string",
  "connectionString": "string"
}
```

<h3 id="post__v2_odsinstancederivatives-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[addOdsInstanceDerivativeRequest](#schemaaddodsinstancederivativerequest)|true|none|

<h3 id="post__v2_odsinstancederivatives-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## get__v2_odsInstanceDerivatives_{id}

`GET /v2/odsInstanceDerivatives/{id}`

<h3 id="get__v2_odsinstancederivatives_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

> Example responses

> 200 Response

```json
{
  "id": 0,
  "odsInstanceId": 0,
  "derivativeType": "string"
}
```

<h3 id="get__v2_odsinstancederivatives_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[odsInstanceDerivativeModel](#schemaodsinstancederivativemodel)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## put__v2_odsInstanceDerivatives_{id}

`PUT /v2/odsInstanceDerivatives/{id}`

> Body parameter

```json
{
  "odsInstanceId": 0,
  "derivativeType": "string",
  "connectionString": "string"
}
```

<h3 id="put__v2_odsinstancederivatives_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|
|body|body|[editOdsInstanceDerivativeRequest](#schemaeditodsinstancederivativerequest)|true|none|

<h3 id="put__v2_odsinstancederivatives_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## delete__v2_odsInstanceDerivatives_{id}

`DELETE /v2/odsInstanceDerivatives/{id}`

<h3 id="delete__v2_odsinstancederivatives_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="delete__v2_odsinstancederivatives_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

<h1 id="admin-api-documentation-odsinstancecontexts">OdsInstanceContexts</h1>

## get__v2_odsInstanceContexts

`GET /v2/odsInstanceContexts`

<h3 id="get__v2_odsinstancecontexts-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|offset|query|integer(int32)|false|Indicates how many items should be skipped before returning results.|
|limit|query|integer(int32)|false|Indicates the maximum number of items that should be returned in the results.|
|orderBy|query|string|false|Indicates the property name by which the results will be sorted.|
|direction|query|string|false|Indicates whether the result should be sorted in descending order (DESC) or ascending order (ASC).|

#### Enumerated Values

|Parameter|Value|
|---|---|
|direction|Ascending|
|direction|Descending|

> Example responses

> 200 Response

```json
[
  {
    "id": 0,
    "odsInstanceId": 0,
    "contextKey": "string",
    "contextValue": "string"
  }
]
```

<h3 id="get__v2_odsinstancecontexts-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|Inline|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<h3 id="get__v2_odsinstancecontexts-responseschema">Response Schema</h3>

Status Code **200**

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|[[odsInstanceContextModel](#schemaodsinstancecontextmodel)]|false|none|none|
|» id|integer(int32)|false|none|none|
|» odsInstanceId|integer(int32)|false|none|none|
|» contextKey|string¦null|false|none|none|
|» contextValue|string¦null|false|none|none|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## post__v2_odsInstanceContexts

`POST /v2/odsInstanceContexts`

> Body parameter

```json
{
  "odsInstanceId": 0,
  "contextKey": "string",
  "contextValue": "string"
}
```

<h3 id="post__v2_odsinstancecontexts-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[addOdsInstanceContextRequest](#schemaaddodsinstancecontextrequest)|true|none|

<h3 id="post__v2_odsinstancecontexts-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## get__v2_odsInstanceContexts_{id}

`GET /v2/odsInstanceContexts/{id}`

<h3 id="get__v2_odsinstancecontexts_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

> Example responses

> 200 Response

```json
{
  "id": 0,
  "odsInstanceId": 0,
  "contextKey": "string",
  "contextValue": "string"
}
```

<h3 id="get__v2_odsinstancecontexts_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[odsInstanceContextModel](#schemaodsinstancecontextmodel)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## put__v2_odsInstanceContexts_{id}

`PUT /v2/odsInstanceContexts/{id}`

> Body parameter

```json
{
  "odsInstanceId": 0,
  "contextKey": "string",
  "contextValue": "string"
}
```

<h3 id="put__v2_odsinstancecontexts_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|
|body|body|[editOdsInstanceContextRequest](#schemaeditodsinstancecontextrequest)|true|none|

<h3 id="put__v2_odsinstancecontexts_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## delete__v2_odsInstanceContexts_{id}

`DELETE /v2/odsInstanceContexts/{id}`

<h3 id="delete__v2_odsinstancecontexts_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="delete__v2_odsinstancecontexts_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

<h1 id="admin-api-documentation-claimsets">ClaimSets</h1>

## get__v2_claimSets_{id}_export

`GET /v2/claimSets/{id}/export`

<h3 id="get__v2_claimsets_{id}_export-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

> Example responses

> 200 Response

```json
{
  "id": 0,
  "name": "string",
  "_isSystemReserved": true,
  "_applications": [
    {
      "applicationName": "string"
    }
  ],
  "resourceClaims": [
    {
      "id": 0,
      "name": "string",
      "actions": [
        {
          "name": "string",
          "enabled": true
        }
      ],
      "_defaultAuthorizationStrategiesForCRUD": [
        {
          "actionId": 0,
          "actionName": "string",
          "authorizationStrategies": [
            {
              "authStrategyId": 0,
              "authStrategyName": "string",
              "isInheritedFromParent": true
            }
          ]
        }
      ],
      "authorizationStrategyOverridesForCRUD": [
        {
          "actionId": 0,
          "actionName": "string",
          "authorizationStrategies": [
            {
              "authStrategyId": 0,
              "authStrategyName": "string",
              "isInheritedFromParent": true
            }
          ]
        }
      ],
      "children": [
        {}
      ]
    }
  ]
}
```

<h3 id="get__v2_claimsets_{id}_export-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[claimSetDetailsModel](#schemaclaimsetdetailsmodel)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## get__v2_claimSets

`GET /v2/claimSets`

<h3 id="get__v2_claimsets-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|offset|query|integer(int32)|false|Indicates how many items should be skipped before returning results.|
|limit|query|integer(int32)|false|Indicates the maximum number of items that should be returned in the results.|
|orderBy|query|string|false|Indicates the property name by which the results will be sorted.|
|direction|query|string|false|Indicates whether the result should be sorted in descending order (DESC) or ascending order (ASC).|
|id|query|integer(int32)|false|Claim set id|
|name|query|string|false|Claim set name|

#### Enumerated Values

|Parameter|Value|
|---|---|
|direction|Ascending|
|direction|Descending|

> Example responses

> 200 Response

```json
[
  {
    "id": 0,
    "name": "string",
    "_isSystemReserved": true,
    "_applications": [
      {
        "applicationName": "string"
      }
    ]
  }
]
```

<h3 id="get__v2_claimsets-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|Inline|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<h3 id="get__v2_claimsets-responseschema">Response Schema</h3>

Status Code **200**

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|[[claimSetModel](#schemaclaimsetmodel)]|false|none|none|
|» id|integer(int32)|false|none|none|
|» name|string¦null|false|none|none|
|» _isSystemReserved|boolean|false|none|none|
|» _applications|[[simpleApplicationModel](#schemasimpleapplicationmodel)]¦null|false|none|none|
|»» applicationName|string¦null|false|none|none|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## post__v2_claimSets

`POST /v2/claimSets`

> Body parameter

```json
{
  "name": "string"
}
```

<h3 id="post__v2_claimsets-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[addClaimSetRequest](#schemaaddclaimsetrequest)|true|none|

<h3 id="post__v2_claimsets-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## get__v2_claimSets_{id}

`GET /v2/claimSets/{id}`

<h3 id="get__v2_claimsets_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

> Example responses

> 200 Response

```json
{
  "id": 0,
  "name": "string",
  "_isSystemReserved": true,
  "_applications": [
    {
      "applicationName": "string"
    }
  ],
  "resourceClaims": [
    {
      "id": 0,
      "name": "string",
      "actions": [
        {
          "name": "string",
          "enabled": true
        }
      ],
      "_defaultAuthorizationStrategiesForCRUD": [
        {
          "actionId": 0,
          "actionName": "string",
          "authorizationStrategies": [
            {
              "authStrategyId": 0,
              "authStrategyName": "string",
              "isInheritedFromParent": true
            }
          ]
        }
      ],
      "authorizationStrategyOverridesForCRUD": [
        {
          "actionId": 0,
          "actionName": "string",
          "authorizationStrategies": [
            {
              "authStrategyId": 0,
              "authStrategyName": "string",
              "isInheritedFromParent": true
            }
          ]
        }
      ],
      "children": [
        {}
      ]
    }
  ]
}
```

<h3 id="get__v2_claimsets_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[claimSetDetailsModel](#schemaclaimsetdetailsmodel)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## put__v2_claimSets_{id}

`PUT /v2/claimSets/{id}`

> Body parameter

```json
{
  "name": "string"
}
```

<h3 id="put__v2_claimsets_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|
|body|body|[editClaimSetRequest](#schemaeditclaimsetrequest)|true|none|

<h3 id="put__v2_claimsets_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## delete__v2_claimSets_{id}

`DELETE /v2/claimSets/{id}`

<h3 id="delete__v2_claimsets_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="delete__v2_claimsets_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## post__v2_claimSets_copy

`POST /v2/claimSets/copy`

> Body parameter

```json
{
  "originalId": 0,
  "name": "string"
}
```

<h3 id="post__v2_claimsets_copy-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[copyClaimSetRequest](#schemacopyclaimsetrequest)|true|none|

<h3 id="post__v2_claimsets_copy-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## post__v2_claimSets_import

`POST /v2/claimSets/import`

> Body parameter

```json
{
  "name": "string",
  "resourceClaims": [
    {
      "id": 0,
      "name": "string",
      "actions": [
        {
          "name": "string",
          "enabled": true
        }
      ],
      "_defaultAuthorizationStrategiesForCRUD": [
        {
          "actionId": 0,
          "actionName": "string",
          "authorizationStrategies": [
            {
              "authStrategyId": 0,
              "authStrategyName": "string",
              "isInheritedFromParent": true
            }
          ]
        }
      ],
      "authorizationStrategyOverridesForCRUD": [
        {
          "actionId": 0,
          "actionName": "string",
          "authorizationStrategies": [
            {
              "authStrategyId": 0,
              "authStrategyName": "string",
              "isInheritedFromParent": true
            }
          ]
        }
      ],
      "children": [
        {}
      ]
    }
  ]
}
```

<h3 id="post__v2_claimsets_import-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[importClaimSetRequest](#schemaimportclaimsetrequest)|true|none|

<h3 id="post__v2_claimsets_import-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## post__v2_claimSets_{claimSetId}_resourceClaimActions_{resourceClaimId}_overrideAuthorizationStrategy

`POST /v2/claimSets/{claimSetId}/resourceClaimActions/{resourceClaimId}/overrideAuthorizationStrategy`

> Body parameter

```json
{
  "actionName": "string",
  "authorizationStrategies": [
    "string"
  ]
}
```

<h3 id="post__v2_claimsets_{claimsetid}_resourceclaimactions_{resourceclaimid}_overrideauthorizationstrategy-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|claimSetId|path|integer(int32)|true|none|
|resourceClaimId|path|integer(int32)|true|none|
|body|body|[overrideAuthStategyOnClaimSetRequest](#schemaoverrideauthstategyonclaimsetrequest)|true|none|

<h3 id="post__v2_claimsets_{claimsetid}_resourceclaimactions_{resourceclaimid}_overrideauthorizationstrategy-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## post__v2_claimSets_{claimSetId}_resourceClaimActions_{resourceClaimId}_resetAuthorizationStrategies

`POST /v2/claimSets/{claimSetId}/resourceClaimActions/{resourceClaimId}/resetAuthorizationStrategies`

<h3 id="post__v2_claimsets_{claimsetid}_resourceclaimactions_{resourceclaimid}_resetauthorizationstrategies-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|claimSetId|path|integer(int32)|true|none|
|resourceClaimId|path|integer(int32)|true|none|

<h3 id="post__v2_claimsets_{claimsetid}_resourceclaimactions_{resourceclaimid}_resetauthorizationstrategies-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## post__v2_claimSets_{claimSetId}_resourceClaimActions

`POST /v2/claimSets/{claimSetId}/resourceClaimActions`

> Body parameter

```json
{
  "resourceClaimId": 0,
  "resourceClaimActions": [
    {
      "name": "string",
      "enabled": true
    }
  ]
}
```

<h3 id="post__v2_claimsets_{claimsetid}_resourceclaimactions-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|claimSetId|path|integer(int32)|true|none|
|body|body|[addResourceClaimOnClaimSetRequest](#schemaaddresourceclaimonclaimsetrequest)|true|none|

<h3 id="post__v2_claimsets_{claimsetid}_resourceclaimactions-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## put__v2_claimSets_{claimSetId}_resourceClaimActions_{resourceClaimId}

`PUT /v2/claimSets/{claimSetId}/resourceClaimActions/{resourceClaimId}`

> Body parameter

```json
{
  "resourceClaimActions": [
    {
      "name": "string",
      "enabled": true
    }
  ]
}
```

<h3 id="put__v2_claimsets_{claimsetid}_resourceclaimactions_{resourceclaimid}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|claimSetId|path|integer(int32)|true|none|
|resourceClaimId|path|integer(int32)|true|none|
|body|body|[editResourceClaimOnClaimSetRequest](#schemaeditresourceclaimonclaimsetrequest)|true|none|

<h3 id="put__v2_claimsets_{claimsetid}_resourceclaimactions_{resourceclaimid}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## delete__v2_claimSets_{claimSetId}_resourceClaimActions_{resourceClaimId}

`DELETE /v2/claimSets/{claimSetId}/resourceClaimActions/{resourceClaimId}`

<h3 id="delete__v2_claimsets_{claimsetid}_resourceclaimactions_{resourceclaimid}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|claimSetId|path|integer(int32)|true|none|
|resourceClaimId|path|integer(int32)|true|none|

<h3 id="delete__v2_claimsets_{claimsetid}_resourceclaimactions_{resourceclaimid}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

<h1 id="admin-api-documentation-authorizationstrategies">AuthorizationStrategies</h1>

## get__v2_authorizationStrategies

`GET /v2/authorizationStrategies`

<h3 id="get__v2_authorizationstrategies-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|offset|query|integer(int32)|false|Indicates how many items should be skipped before returning results.|
|limit|query|integer(int32)|false|Indicates the maximum number of items that should be returned in the results.|
|orderBy|query|string|false|Indicates the property name by which the results will be sorted.|
|direction|query|string|false|Indicates whether the result should be sorted in descending order (DESC) or ascending order (ASC).|

#### Enumerated Values

|Parameter|Value|
|---|---|
|direction|Ascending|
|direction|Descending|

> Example responses

> 200 Response

```json
[
  {
    "id": 0,
    "name": "string",
    "displayName": "string"
  }
]
```

<h3 id="get__v2_authorizationstrategies-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|Inline|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<h3 id="get__v2_authorizationstrategies-responseschema">Response Schema</h3>

Status Code **200**

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|[[authorizationStrategyModel](#schemaauthorizationstrategymodel)]|false|none|none|
|» id|integer(int32)|false|none|none|
|» name|string¦null|false|none|none|
|» displayName|string¦null|false|none|none|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

<h1 id="admin-api-documentation-applications">Applications</h1>

## get__v2_applications

`GET /v2/applications`

<h3 id="get__v2_applications-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|offset|query|integer(int32)|false|Indicates how many items should be skipped before returning results.|
|limit|query|integer(int32)|false|Indicates the maximum number of items that should be returned in the results.|
|orderBy|query|string|false|Indicates the property name by which the results will be sorted.|
|direction|query|string|false|Indicates whether the result should be sorted in descending order (DESC) or ascending order (ASC).|
|id|query|integer(int32)|false|Application id|
|applicationName|query|string|false|Application name|
|claimsetName|query|string|false|Claim set name|
|ids|query|string|false|none|

#### Enumerated Values

|Parameter|Value|
|---|---|
|direction|Ascending|
|direction|Descending|

> Example responses

> 200 Response

```json
[
  {
    "id": 0,
    "applicationName": "string",
    "claimSetName": "string",
    "educationOrganizationIds": [
      0
    ],
    "vendorId": 0,
    "profileIds": [
      0
    ],
    "odsInstanceIds": [
      0
    ],
    "enabled": true
  }
]
```

<h3 id="get__v2_applications-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|Inline|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<h3 id="get__v2_applications-responseschema">Response Schema</h3>

Status Code **200**

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|[[applicationModel](#schemaapplicationmodel)]|false|none|none|
|» id|integer(int32)|false|none|none|
|» applicationName|string¦null|false|none|none|
|» claimSetName|string¦null|false|none|none|
|» educationOrganizationIds|[integer]¦null|false|none|none|
|» vendorId|integer(int32)¦null|false|none|none|
|» profileIds|[integer]¦null|false|none|none|
|» odsInstanceIds|[integer]¦null|false|none|none|
|» enabled|boolean|false|none|none|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## post__v2_applications

`POST /v2/applications`

> Body parameter

```json
{
  "applicationName": "string",
  "vendorId": 0,
  "claimSetName": "string",
  "profileIds": [
    0
  ],
  "educationOrganizationIds": [
    0
  ],
  "odsInstanceIds": [
    0
  ],
  "enabled": true
}
```

<h3 id="post__v2_applications-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[addApplicationRequest](#schemaaddapplicationrequest)|true|none|

> Example responses

> 201 Response

```json
{
  "id": 0,
  "key": "string",
  "secret": "string"
}
```

<h3 id="post__v2_applications-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[applicationResult](#schemaapplicationresult)|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## get__v2_applications_{id}

`GET /v2/applications/{id}`

<h3 id="get__v2_applications_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

> Example responses

> 200 Response

```json
{
  "id": 0,
  "applicationName": "string",
  "claimSetName": "string",
  "educationOrganizationIds": [
    0
  ],
  "vendorId": 0,
  "profileIds": [
    0
  ],
  "odsInstanceIds": [
    0
  ],
  "enabled": true
}
```

<h3 id="get__v2_applications_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[applicationModel](#schemaapplicationmodel)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## put__v2_applications_{id}

`PUT /v2/applications/{id}`

> Body parameter

```json
{
  "applicationName": "string",
  "vendorId": 0,
  "claimSetName": "string",
  "profileIds": [
    0
  ],
  "educationOrganizationIds": [
    0
  ],
  "odsInstanceIds": [
    0
  ],
  "enabled": true
}
```

<h3 id="put__v2_applications_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|
|body|body|[editApplicationRequest](#schemaeditapplicationrequest)|true|none|

<h3 id="put__v2_applications_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## delete__v2_applications_{id}

`DELETE /v2/applications/{id}`

<h3 id="delete__v2_applications_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="delete__v2_applications_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## put__v2_applications_{id}_reset-credential

`PUT /v2/applications/{id}/reset-credential`

<h3 id="put__v2_applications_{id}_reset-credential-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

> Example responses

> 200 Response

```json
{
  "id": 0,
  "key": "string",
  "secret": "string"
}
```

<h3 id="put__v2_applications_{id}_reset-credential-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[applicationResult](#schemaapplicationresult)|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

<h1 id="admin-api-documentation-apiclients">Apiclients</h1>

## get__v2_apiclients

`GET /v2/apiclients`

<h3 id="get__v2_apiclients-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|applicationid|query|integer(int32)|true|none|

> Example responses

> 200 Response

```json
[
  {
    "id": 0,
    "key": "string",
    "name": "string",
    "isApproved": true,
    "useSandbox": true,
    "sandboxType": 0,
    "applicationId": 0,
    "keyStatus": "string",
    "educationOrganizationIds": [
      0
    ],
    "odsInstanceIds": [
      0
    ]
  }
]
```

<h3 id="get__v2_apiclients-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|Inline|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<h3 id="get__v2_apiclients-responseschema">Response Schema</h3>

Status Code **200**

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|[[apiClientModel](#schemaapiclientmodel)]|false|none|none|
|» id|integer(int32)|false|none|none|
|» key|string¦null|false|none|none|
|» name|string¦null|false|none|none|
|» isApproved|boolean|false|none|none|
|» useSandbox|boolean|false|none|none|
|» sandboxType|integer(int32)|false|none|none|
|» applicationId|integer(int32)|false|none|none|
|» keyStatus|string¦null|false|none|none|
|» educationOrganizationIds|[integer]¦null|false|none|none|
|» odsInstanceIds|[integer]¦null|false|none|none|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## post__v2_apiclients

`POST /v2/apiclients`

> Body parameter

```json
{
  "name": "string",
  "isApproved": true,
  "applicationId": 0,
  "odsInstanceIds": [
    0
  ]
}
```

<h3 id="post__v2_apiclients-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[addApiClientRequest](#schemaaddapiclientrequest)|true|none|

> Example responses

> 201 Response

```json
{
  "id": 0,
  "name": "string",
  "key": "string",
  "secret": "string",
  "applicationId": 0
}
```

<h3 id="post__v2_apiclients-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[apiClientResult](#schemaapiclientresult)|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## get__v2_apiclients_{id}

`GET /v2/apiclients/{id}`

<h3 id="get__v2_apiclients_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

> Example responses

> 200 Response

```json
{
  "id": 0,
  "key": "string",
  "name": "string",
  "isApproved": true,
  "useSandbox": true,
  "sandboxType": 0,
  "applicationId": 0,
  "keyStatus": "string",
  "educationOrganizationIds": [
    0
  ],
  "odsInstanceIds": [
    0
  ]
}
```

<h3 id="get__v2_apiclients_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[apiClientModel](#schemaapiclientmodel)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## put__v2_apiclients_{id}

`PUT /v2/apiclients/{id}`

> Body parameter

```json
{
  "name": "string",
  "isApproved": true,
  "applicationId": 0,
  "odsInstanceIds": [
    0
  ]
}
```

<h3 id="put__v2_apiclients_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|
|body|body|[editApiClientRequest](#schemaeditapiclientrequest)|true|none|

<h3 id="put__v2_apiclients_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## delete__v2_apiclients_{id}

`DELETE /v2/apiclients/{id}`

<h3 id="delete__v2_apiclients_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

<h3 id="delete__v2_apiclients_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## put__v2_apiclients_{id}_reset-credential

`PUT /v2/apiclients/{id}/reset-credential`

<h3 id="put__v2_apiclients_{id}_reset-credential-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

> Example responses

> 200 Response

```json
{
  "id": 0,
  "name": "string",
  "key": "string",
  "secret": "string",
  "applicationId": 0
}
```

<h3 id="put__v2_apiclients_{id}_reset-credential-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[apiClientResult](#schemaapiclientresult)|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|Not Found|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

<h1 id="admin-api-documentation-actions">Actions</h1>

## get__v2_actions

`GET /v2/actions`

<h3 id="get__v2_actions-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|offset|query|integer(int32)|false|Indicates how many items should be skipped before returning results.|
|limit|query|integer(int32)|false|Indicates the maximum number of items that should be returned in the results.|
|orderBy|query|string|false|Indicates the property name by which the results will be sorted.|
|direction|query|string|false|Indicates whether the result should be sorted in descending order (DESC) or ascending order (ASC).|
|id|query|integer(int32)|false|Action id|
|name|query|string|false|Action name|

#### Enumerated Values

|Parameter|Value|
|---|---|
|direction|Ascending|
|direction|Descending|

> Example responses

> 200 Response

```json
[
  {
    "id": 0,
    "name": "string",
    "uri": "string"
  }
]
```

<h3 id="get__v2_actions-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|Inline|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|
|403|[Forbidden](https://tools.ietf.org/html/rfc7231#section-6.5.3)|Forbidden|None|
|409|[Conflict](https://tools.ietf.org/html/rfc7231#section-6.5.8)|Conflict|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<h3 id="get__v2_actions-responseschema">Response Schema</h3>

Status Code **200**

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|[[actionModel](#schemaactionmodel)]|false|none|none|
|» id|integer(int32)|false|none|none|
|» name|string¦null|false|none|none|
|» uri|string¦null|false|none|none|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

<h1 id="admin-api-documentation-information">Information</h1>

## get__

`GET /`

> Example responses

> 200 Response

```json
{
  "version": "string",
  "build": "string"
}
```

<h3 id="get__-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[informationResult](#schemainformationresult)|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|[informationResult](#schemainformationresult)|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

<h1 id="admin-api-documentation-connect">Connect</h1>

## post__connect_register

`POST /connect/register`

> Body parameter

```yaml
ClientId: string
ClientSecret: string
DisplayName: string

```

<h3 id="post__connect_register-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|object|false|none|
|» ClientId|body|string|false|none|
|» ClientSecret|body|string|false|none|
|» DisplayName|body|string|false|none|

<h3 id="post__connect_register-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

## post__connect_token

`POST /connect/token`

> Body parameter

```yaml
client_id: string
client_secret: string
grant_type: string
scope: string

```

<h3 id="post__connect_token-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|object|false|none|
|» client_id|body|string|false|none|
|» client_secret|body|string|false|none|
|» grant_type|body|string|false|none|
|» scope|body|string|false|none|

<h3 id="post__connect_token-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|400|[Bad Request](https://tools.ietf.org/html/rfc7231#section-6.5.1)|Bad Request|None|
|500|[Internal Server Error](https://tools.ietf.org/html/rfc7231#section-6.6.1)|Internal Server Error|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
oauth ( Scopes: api )
</aside>

# Schemas

<h2 id="tocS_actionForResourceClaimModel">actionForResourceClaimModel</h2>
<!-- backwards compatibility -->
<a id="schemaactionforresourceclaimmodel"></a>
<a id="schema_actionForResourceClaimModel"></a>
<a id="tocSactionforresourceclaimmodel"></a>
<a id="tocsactionforresourceclaimmodel"></a>

```json
{
  "name": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|none|

<h2 id="tocS_actionModel">actionModel</h2>
<!-- backwards compatibility -->
<a id="schemaactionmodel"></a>
<a id="schema_actionModel"></a>
<a id="tocSactionmodel"></a>
<a id="tocsactionmodel"></a>

```json
{
  "id": 0,
  "name": "string",
  "uri": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|none|
|name|string¦null|false|none|none|
|uri|string¦null|false|none|none|

<h2 id="tocS_actionWithAuthorizationStrategy">actionWithAuthorizationStrategy</h2>
<!-- backwards compatibility -->
<a id="schemaactionwithauthorizationstrategy"></a>
<a id="schema_actionWithAuthorizationStrategy"></a>
<a id="tocSactionwithauthorizationstrategy"></a>
<a id="tocsactionwithauthorizationstrategy"></a>

```json
{
  "actionId": 0,
  "actionName": "string",
  "authorizationStrategies": [
    {
      "authStrategyId": 0,
      "authStrategyName": "string"
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|actionId|integer(int32)|false|none|none|
|actionName|string¦null|false|none|none|
|authorizationStrategies|[[authorizationStrategyModelForAction](#schemaauthorizationstrategymodelforaction)]¦null|false|none|none|

<h2 id="tocS_addApiClientRequest">addApiClientRequest</h2>
<!-- backwards compatibility -->
<a id="schemaaddapiclientrequest"></a>
<a id="schema_addApiClientRequest"></a>
<a id="tocSaddapiclientrequest"></a>
<a id="tocsaddapiclientrequest"></a>

```json
{
  "name": "string",
  "isApproved": true,
  "applicationId": 0,
  "odsInstanceIds": [
    0
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|none|
|isApproved|boolean|false|none|none|
|applicationId|integer(int32)|false|none|none|
|odsInstanceIds|[integer]¦null|false|none|none|

<h2 id="tocS_addApplicationRequest">addApplicationRequest</h2>
<!-- backwards compatibility -->
<a id="schemaaddapplicationrequest"></a>
<a id="schema_addApplicationRequest"></a>
<a id="tocSaddapplicationrequest"></a>
<a id="tocsaddapplicationrequest"></a>

```json
{
  "applicationName": "string",
  "vendorId": 0,
  "claimSetName": "string",
  "profileIds": [
    0
  ],
  "educationOrganizationIds": [
    0
  ],
  "odsInstanceIds": [
    0
  ],
  "enabled": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|applicationName|string¦null|false|none|none|
|vendorId|integer(int32)|false|none|none|
|claimSetName|string¦null|false|none|none|
|profileIds|[integer]¦null|false|none|none|
|educationOrganizationIds|[integer]¦null|false|none|none|
|odsInstanceIds|[integer]¦null|false|none|none|
|enabled|boolean¦null|false|none|none|

<h2 id="tocS_addClaimSetRequest">addClaimSetRequest</h2>
<!-- backwards compatibility -->
<a id="schemaaddclaimsetrequest"></a>
<a id="schema_addClaimSetRequest"></a>
<a id="tocSaddclaimsetrequest"></a>
<a id="tocsaddclaimsetrequest"></a>

```json
{
  "name": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|none|

<h2 id="tocS_addOdsInstanceContextRequest">addOdsInstanceContextRequest</h2>
<!-- backwards compatibility -->
<a id="schemaaddodsinstancecontextrequest"></a>
<a id="schema_addOdsInstanceContextRequest"></a>
<a id="tocSaddodsinstancecontextrequest"></a>
<a id="tocsaddodsinstancecontextrequest"></a>

```json
{
  "odsInstanceId": 0,
  "contextKey": "string",
  "contextValue": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|odsInstanceId|integer(int32)|false|none|none|
|contextKey|string¦null|false|none|none|
|contextValue|string¦null|false|none|none|

<h2 id="tocS_addOdsInstanceDerivativeRequest">addOdsInstanceDerivativeRequest</h2>
<!-- backwards compatibility -->
<a id="schemaaddodsinstancederivativerequest"></a>
<a id="schema_addOdsInstanceDerivativeRequest"></a>
<a id="tocSaddodsinstancederivativerequest"></a>
<a id="tocsaddodsinstancederivativerequest"></a>

```json
{
  "odsInstanceId": 0,
  "derivativeType": "string",
  "connectionString": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|odsInstanceId|integer(int32)|false|none|none|
|derivativeType|string¦null|false|none|none|
|connectionString|string¦null|false|none|none|

<h2 id="tocS_addOdsInstanceRequest">addOdsInstanceRequest</h2>
<!-- backwards compatibility -->
<a id="schemaaddodsinstancerequest"></a>
<a id="schema_addOdsInstanceRequest"></a>
<a id="tocSaddodsinstancerequest"></a>
<a id="tocsaddodsinstancerequest"></a>

```json
{
  "name": "string",
  "instanceType": "string",
  "connectionString": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|none|
|instanceType|string¦null|false|none|none|
|connectionString|string¦null|false|none|none|

<h2 id="tocS_addProfileRequest">addProfileRequest</h2>
<!-- backwards compatibility -->
<a id="schemaaddprofilerequest"></a>
<a id="schema_addProfileRequest"></a>
<a id="tocSaddprofilerequest"></a>
<a id="tocsaddprofilerequest"></a>

```json
"{\n  \"name\": \"Test-Profile\",\n  \"definition\": \"<Profile name=\\\"Test-Profile\\\"><Resource name=\\\"Resource1\\\"><ReadContentType memberSelection=\\\"IncludeOnly\\\"><Collection name=\\\"Collection1\\\" memberSelection=\\\"IncludeOnly\\\"><Property name=\\\"Property1\\\" /><Property name=\\\"Property2\\\" /></Collection></ReadContentType><WriteContentType memberSelection=\\\"IncludeOnly\\\"><Collection name=\\\"Collection2\\\" memberSelection=\\\"IncludeOnly\\\"><Property name=\\\"Property1\\\" /><Property name=\\\"Property2\\\" /></Collection></WriteContentType></Resource></Profile>\"\n}"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|none|
|definition|string¦null|false|none|none|

<h2 id="tocS_addResourceClaimOnClaimSetRequest">addResourceClaimOnClaimSetRequest</h2>
<!-- backwards compatibility -->
<a id="schemaaddresourceclaimonclaimsetrequest"></a>
<a id="schema_addResourceClaimOnClaimSetRequest"></a>
<a id="tocSaddresourceclaimonclaimsetrequest"></a>
<a id="tocsaddresourceclaimonclaimsetrequest"></a>

```json
{
  "resourceClaimId": 0,
  "resourceClaimActions": [
    {
      "name": "string",
      "enabled": true
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|resourceClaimId|integer(int32)|false|none|none|
|resourceClaimActions|[[resourceClaimAction](#schemaresourceclaimaction)]¦null|false|none|none|

<h2 id="tocS_addVendorRequest">addVendorRequest</h2>
<!-- backwards compatibility -->
<a id="schemaaddvendorrequest"></a>
<a id="schema_addVendorRequest"></a>
<a id="tocSaddvendorrequest"></a>
<a id="tocsaddvendorrequest"></a>

```json
{
  "company": "string",
  "namespacePrefixes": "string",
  "contactName": "string",
  "contactEmailAddress": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|company|string¦null|false|none|none|
|namespacePrefixes|string¦null|false|none|none|
|contactName|string¦null|false|none|none|
|contactEmailAddress|string¦null|false|none|none|

<h2 id="tocS_adminApiError">adminApiError</h2>
<!-- backwards compatibility -->
<a id="schemaadminapierror"></a>
<a id="schema_adminApiError"></a>
<a id="tocSadminapierror"></a>
<a id="tocsadminapierror"></a>

```json
{}

```

### Properties

*None*

<h2 id="tocS_apiClientModel">apiClientModel</h2>
<!-- backwards compatibility -->
<a id="schemaapiclientmodel"></a>
<a id="schema_apiClientModel"></a>
<a id="tocSapiclientmodel"></a>
<a id="tocsapiclientmodel"></a>

```json
{
  "id": 0,
  "key": "string",
  "name": "string",
  "isApproved": true,
  "useSandbox": true,
  "sandboxType": 0,
  "applicationId": 0,
  "keyStatus": "string",
  "educationOrganizationIds": [
    0
  ],
  "odsInstanceIds": [
    0
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|none|
|key|string¦null|false|none|none|
|name|string¦null|false|none|none|
|isApproved|boolean|false|none|none|
|useSandbox|boolean|false|none|none|
|sandboxType|integer(int32)|false|none|none|
|applicationId|integer(int32)|false|none|none|
|keyStatus|string¦null|false|none|none|
|educationOrganizationIds|[integer]¦null|false|none|none|
|odsInstanceIds|[integer]¦null|false|none|none|

<h2 id="tocS_apiClientResult">apiClientResult</h2>
<!-- backwards compatibility -->
<a id="schemaapiclientresult"></a>
<a id="schema_apiClientResult"></a>
<a id="tocSapiclientresult"></a>
<a id="tocsapiclientresult"></a>

```json
{
  "id": 0,
  "name": "string",
  "key": "string",
  "secret": "string",
  "applicationId": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|none|
|name|string¦null|false|none|none|
|key|string¦null|false|none|none|
|secret|string¦null|false|none|none|
|applicationId|integer(int32)|false|none|none|

<h2 id="tocS_applicationModel">applicationModel</h2>
<!-- backwards compatibility -->
<a id="schemaapplicationmodel"></a>
<a id="schema_applicationModel"></a>
<a id="tocSapplicationmodel"></a>
<a id="tocsapplicationmodel"></a>

```json
{
  "id": 0,
  "applicationName": "string",
  "claimSetName": "string",
  "educationOrganizationIds": [
    0
  ],
  "vendorId": 0,
  "profileIds": [
    0
  ],
  "odsInstanceIds": [
    0
  ],
  "enabled": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|none|
|applicationName|string¦null|false|none|none|
|claimSetName|string¦null|false|none|none|
|educationOrganizationIds|[integer]¦null|false|none|none|
|vendorId|integer(int32)¦null|false|none|none|
|profileIds|[integer]¦null|false|none|none|
|odsInstanceIds|[integer]¦null|false|none|none|
|enabled|boolean|false|none|none|

<h2 id="tocS_applicationResult">applicationResult</h2>
<!-- backwards compatibility -->
<a id="schemaapplicationresult"></a>
<a id="schema_applicationResult"></a>
<a id="tocSapplicationresult"></a>
<a id="tocsapplicationresult"></a>

```json
{
  "id": 0,
  "key": "string",
  "secret": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|none|
|key|string¦null|false|none|none|
|secret|string¦null|false|none|none|

<h2 id="tocS_authorizationStrategy">authorizationStrategy</h2>
<!-- backwards compatibility -->
<a id="schemaauthorizationstrategy"></a>
<a id="schema_authorizationStrategy"></a>
<a id="tocSauthorizationstrategy"></a>
<a id="tocsauthorizationstrategy"></a>

```json
{
  "authStrategyId": 0,
  "authStrategyName": "string",
  "isInheritedFromParent": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|authStrategyId|integer(int32)|false|none|none|
|authStrategyName|string¦null|false|none|none|
|isInheritedFromParent|boolean|false|none|none|

<h2 id="tocS_authorizationStrategyModel">authorizationStrategyModel</h2>
<!-- backwards compatibility -->
<a id="schemaauthorizationstrategymodel"></a>
<a id="schema_authorizationStrategyModel"></a>
<a id="tocSauthorizationstrategymodel"></a>
<a id="tocsauthorizationstrategymodel"></a>

```json
{
  "id": 0,
  "name": "string",
  "displayName": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|none|
|name|string¦null|false|none|none|
|displayName|string¦null|false|none|none|

<h2 id="tocS_authorizationStrategyModelForAction">authorizationStrategyModelForAction</h2>
<!-- backwards compatibility -->
<a id="schemaauthorizationstrategymodelforaction"></a>
<a id="schema_authorizationStrategyModelForAction"></a>
<a id="tocSauthorizationstrategymodelforaction"></a>
<a id="tocsauthorizationstrategymodelforaction"></a>

```json
{
  "authStrategyId": 0,
  "authStrategyName": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|authStrategyId|integer(int32)|false|none|none|
|authStrategyName|string¦null|false|none|none|

<h2 id="tocS_claimSetDetailsModel">claimSetDetailsModel</h2>
<!-- backwards compatibility -->
<a id="schemaclaimsetdetailsmodel"></a>
<a id="schema_claimSetDetailsModel"></a>
<a id="tocSclaimsetdetailsmodel"></a>
<a id="tocsclaimsetdetailsmodel"></a>

```json
{
  "id": 0,
  "name": "string",
  "_isSystemReserved": true,
  "_applications": [
    {
      "applicationName": "string"
    }
  ],
  "resourceClaims": [
    {
      "id": 0,
      "name": "string",
      "actions": [
        {
          "name": "string",
          "enabled": true
        }
      ],
      "_defaultAuthorizationStrategiesForCRUD": [
        {
          "actionId": 0,
          "actionName": "string",
          "authorizationStrategies": [
            {
              "authStrategyId": 0,
              "authStrategyName": "string",
              "isInheritedFromParent": true
            }
          ]
        }
      ],
      "authorizationStrategyOverridesForCRUD": [
        {
          "actionId": 0,
          "actionName": "string",
          "authorizationStrategies": [
            {
              "authStrategyId": 0,
              "authStrategyName": "string",
              "isInheritedFromParent": true
            }
          ]
        }
      ],
      "children": [
        {}
      ]
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|none|
|name|string¦null|false|none|none|
|_isSystemReserved|boolean|false|none|none|
|_applications|[[simpleApplicationModel](#schemasimpleapplicationmodel)]¦null|false|none|none|
|resourceClaims|[[claimSetResourceClaimModel](#schemaclaimsetresourceclaimmodel)]¦null|false|none|none|

<h2 id="tocS_claimSetModel">claimSetModel</h2>
<!-- backwards compatibility -->
<a id="schemaclaimsetmodel"></a>
<a id="schema_claimSetModel"></a>
<a id="tocSclaimsetmodel"></a>
<a id="tocsclaimsetmodel"></a>

```json
{
  "id": 0,
  "name": "string",
  "_isSystemReserved": true,
  "_applications": [
    {
      "applicationName": "string"
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|none|
|name|string¦null|false|none|none|
|_isSystemReserved|boolean|false|none|none|
|_applications|[[simpleApplicationModel](#schemasimpleapplicationmodel)]¦null|false|none|none|

<h2 id="tocS_claimSetResourceClaimActionAuthStrategies">claimSetResourceClaimActionAuthStrategies</h2>
<!-- backwards compatibility -->
<a id="schemaclaimsetresourceclaimactionauthstrategies"></a>
<a id="schema_claimSetResourceClaimActionAuthStrategies"></a>
<a id="tocSclaimsetresourceclaimactionauthstrategies"></a>
<a id="tocsclaimsetresourceclaimactionauthstrategies"></a>

```json
{
  "actionId": 0,
  "actionName": "string",
  "authorizationStrategies": [
    {
      "authStrategyId": 0,
      "authStrategyName": "string",
      "isInheritedFromParent": true
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|actionId|integer(int32)¦null|false|none|none|
|actionName|string¦null|false|none|none|
|authorizationStrategies|[[authorizationStrategy](#schemaauthorizationstrategy)]¦null|false|none|none|

<h2 id="tocS_claimSetResourceClaimModel">claimSetResourceClaimModel</h2>
<!-- backwards compatibility -->
<a id="schemaclaimsetresourceclaimmodel"></a>
<a id="schema_claimSetResourceClaimModel"></a>
<a id="tocSclaimsetresourceclaimmodel"></a>
<a id="tocsclaimsetresourceclaimmodel"></a>

```json
{
  "id": 0,
  "name": "string",
  "actions": [
    {
      "name": "string",
      "enabled": true
    }
  ],
  "_defaultAuthorizationStrategiesForCRUD": [
    {
      "actionId": 0,
      "actionName": "string",
      "authorizationStrategies": [
        {
          "authStrategyId": 0,
          "authStrategyName": "string",
          "isInheritedFromParent": true
        }
      ]
    }
  ],
  "authorizationStrategyOverridesForCRUD": [
    {
      "actionId": 0,
      "actionName": "string",
      "authorizationStrategies": [
        {
          "authStrategyId": 0,
          "authStrategyName": "string",
          "isInheritedFromParent": true
        }
      ]
    }
  ],
  "children": [
    {
      "id": 0,
      "name": "string",
      "actions": [
        {
          "name": "string",
          "enabled": true
        }
      ],
      "_defaultAuthorizationStrategiesForCRUD": [
        {
          "actionId": 0,
          "actionName": "string",
          "authorizationStrategies": [
            {
              "authStrategyId": 0,
              "authStrategyName": "string",
              "isInheritedFromParent": true
            }
          ]
        }
      ],
      "authorizationStrategyOverridesForCRUD": [
        {
          "actionId": 0,
          "actionName": "string",
          "authorizationStrategies": [
            {
              "authStrategyId": 0,
              "authStrategyName": "string",
              "isInheritedFromParent": true
            }
          ]
        }
      ],
      "children": []
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|none|
|name|string¦null|false|none|none|
|actions|[[resourceClaimAction](#schemaresourceclaimaction)]¦null|false|none|none|
|_defaultAuthorizationStrategiesForCRUD|[[claimSetResourceClaimActionAuthStrategies](#schemaclaimsetresourceclaimactionauthstrategies)]¦null|false|none|none|
|authorizationStrategyOverridesForCRUD|[[claimSetResourceClaimActionAuthStrategies](#schemaclaimsetresourceclaimactionauthstrategies)]¦null|false|none|none|
|children|[[claimSetResourceClaimModel](#schemaclaimsetresourceclaimmodel)]¦null|false|none|none|

<h2 id="tocS_copyClaimSetRequest">copyClaimSetRequest</h2>
<!-- backwards compatibility -->
<a id="schemacopyclaimsetrequest"></a>
<a id="schema_copyClaimSetRequest"></a>
<a id="tocScopyclaimsetrequest"></a>
<a id="tocscopyclaimsetrequest"></a>

```json
{
  "originalId": 0,
  "name": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|originalId|integer(int32)|false|none|none|
|name|string¦null|false|none|none|

<h2 id="tocS_editApiClientRequest">editApiClientRequest</h2>
<!-- backwards compatibility -->
<a id="schemaeditapiclientrequest"></a>
<a id="schema_editApiClientRequest"></a>
<a id="tocSeditapiclientrequest"></a>
<a id="tocseditapiclientrequest"></a>

```json
{
  "name": "string",
  "isApproved": true,
  "applicationId": 0,
  "odsInstanceIds": [
    0
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|none|
|isApproved|boolean|false|none|none|
|applicationId|integer(int32)|false|none|none|
|odsInstanceIds|[integer]¦null|false|none|none|

<h2 id="tocS_editApplicationRequest">editApplicationRequest</h2>
<!-- backwards compatibility -->
<a id="schemaeditapplicationrequest"></a>
<a id="schema_editApplicationRequest"></a>
<a id="tocSeditapplicationrequest"></a>
<a id="tocseditapplicationrequest"></a>

```json
{
  "applicationName": "string",
  "vendorId": 0,
  "claimSetName": "string",
  "profileIds": [
    0
  ],
  "educationOrganizationIds": [
    0
  ],
  "odsInstanceIds": [
    0
  ],
  "enabled": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|applicationName|string¦null|false|none|none|
|vendorId|integer(int32)|false|none|none|
|claimSetName|string¦null|false|none|none|
|profileIds|[integer]¦null|false|none|none|
|educationOrganizationIds|[integer]¦null|false|none|none|
|odsInstanceIds|[integer]¦null|false|none|none|
|enabled|boolean¦null|false|none|none|

<h2 id="tocS_editClaimSetRequest">editClaimSetRequest</h2>
<!-- backwards compatibility -->
<a id="schemaeditclaimsetrequest"></a>
<a id="schema_editClaimSetRequest"></a>
<a id="tocSeditclaimsetrequest"></a>
<a id="tocseditclaimsetrequest"></a>

```json
{
  "name": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|none|

<h2 id="tocS_editOdsInstanceContextRequest">editOdsInstanceContextRequest</h2>
<!-- backwards compatibility -->
<a id="schemaeditodsinstancecontextrequest"></a>
<a id="schema_editOdsInstanceContextRequest"></a>
<a id="tocSeditodsinstancecontextrequest"></a>
<a id="tocseditodsinstancecontextrequest"></a>

```json
{
  "odsInstanceId": 0,
  "contextKey": "string",
  "contextValue": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|odsInstanceId|integer(int32)|false|none|none|
|contextKey|string¦null|false|none|none|
|contextValue|string¦null|false|none|none|

<h2 id="tocS_editOdsInstanceDerivativeRequest">editOdsInstanceDerivativeRequest</h2>
<!-- backwards compatibility -->
<a id="schemaeditodsinstancederivativerequest"></a>
<a id="schema_editOdsInstanceDerivativeRequest"></a>
<a id="tocSeditodsinstancederivativerequest"></a>
<a id="tocseditodsinstancederivativerequest"></a>

```json
{
  "odsInstanceId": 0,
  "derivativeType": "string",
  "connectionString": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|odsInstanceId|integer(int32)|false|none|none|
|derivativeType|string¦null|false|none|none|
|connectionString|string¦null|false|none|none|

<h2 id="tocS_editOdsInstanceRequest">editOdsInstanceRequest</h2>
<!-- backwards compatibility -->
<a id="schemaeditodsinstancerequest"></a>
<a id="schema_editOdsInstanceRequest"></a>
<a id="tocSeditodsinstancerequest"></a>
<a id="tocseditodsinstancerequest"></a>

```json
{
  "name": "string",
  "instanceType": "string",
  "connectionString": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|none|
|instanceType|string¦null|false|none|none|
|connectionString|string¦null|false|none|none|

<h2 id="tocS_editProfileRequest">editProfileRequest</h2>
<!-- backwards compatibility -->
<a id="schemaeditprofilerequest"></a>
<a id="schema_editProfileRequest"></a>
<a id="tocSeditprofilerequest"></a>
<a id="tocseditprofilerequest"></a>

```json
"{\n  \"name\": \"Test-Profile\",\n  \"definition\": \"<Profile name=\\\"Test-Profile\\\"><Resource name=\\\"Resource1\\\"><ReadContentType memberSelection=\\\"IncludeOnly\\\"><Collection name=\\\"Collection1\\\" memberSelection=\\\"IncludeOnly\\\"><Property name=\\\"Property1\\\" /><Property name=\\\"Property2\\\" /></Collection></ReadContentType><WriteContentType memberSelection=\\\"IncludeOnly\\\"><Collection name=\\\"Collection2\\\" memberSelection=\\\"IncludeOnly\\\"><Property name=\\\"Property1\\\" /><Property name=\\\"Property2\\\" /></Collection></WriteContentType></Resource></Profile>\"\n}"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|none|
|definition|string¦null|false|none|none|

<h2 id="tocS_editResourceClaimOnClaimSetRequest">editResourceClaimOnClaimSetRequest</h2>
<!-- backwards compatibility -->
<a id="schemaeditresourceclaimonclaimsetrequest"></a>
<a id="schema_editResourceClaimOnClaimSetRequest"></a>
<a id="tocSeditresourceclaimonclaimsetrequest"></a>
<a id="tocseditresourceclaimonclaimsetrequest"></a>

```json
{
  "resourceClaimActions": [
    {
      "name": "string",
      "enabled": true
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|resourceClaimActions|[[resourceClaimAction](#schemaresourceclaimaction)]¦null|false|none|none|

<h2 id="tocS_editVendorRequest">editVendorRequest</h2>
<!-- backwards compatibility -->
<a id="schemaeditvendorrequest"></a>
<a id="schema_editVendorRequest"></a>
<a id="tocSeditvendorrequest"></a>
<a id="tocseditvendorrequest"></a>

```json
{
  "company": "string",
  "namespacePrefixes": "string",
  "contactName": "string",
  "contactEmailAddress": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|company|string¦null|false|none|none|
|namespacePrefixes|string¦null|false|none|none|
|contactName|string¦null|false|none|none|
|contactEmailAddress|string¦null|false|none|none|

<h2 id="tocS_importClaimSetRequest">importClaimSetRequest</h2>
<!-- backwards compatibility -->
<a id="schemaimportclaimsetrequest"></a>
<a id="schema_importClaimSetRequest"></a>
<a id="tocSimportclaimsetrequest"></a>
<a id="tocsimportclaimsetrequest"></a>

```json
{
  "name": "string",
  "resourceClaims": [
    {
      "id": 0,
      "name": "string",
      "actions": [
        {
          "name": "string",
          "enabled": true
        }
      ],
      "_defaultAuthorizationStrategiesForCRUD": [
        {
          "actionId": 0,
          "actionName": "string",
          "authorizationStrategies": [
            {
              "authStrategyId": 0,
              "authStrategyName": "string",
              "isInheritedFromParent": true
            }
          ]
        }
      ],
      "authorizationStrategyOverridesForCRUD": [
        {
          "actionId": 0,
          "actionName": "string",
          "authorizationStrategies": [
            {
              "authStrategyId": 0,
              "authStrategyName": "string",
              "isInheritedFromParent": true
            }
          ]
        }
      ],
      "children": [
        {}
      ]
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|none|
|resourceClaims|[[claimSetResourceClaimModel](#schemaclaimsetresourceclaimmodel)]¦null|false|none|none|

<h2 id="tocS_informationResult">informationResult</h2>
<!-- backwards compatibility -->
<a id="schemainformationresult"></a>
<a id="schema_informationResult"></a>
<a id="tocSinformationresult"></a>
<a id="tocsinformationresult"></a>

```json
{
  "version": "string",
  "build": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|version|string¦null|false|none|none|
|build|string¦null|false|none|none|

<h2 id="tocS_odsInstanceContextModel">odsInstanceContextModel</h2>
<!-- backwards compatibility -->
<a id="schemaodsinstancecontextmodel"></a>
<a id="schema_odsInstanceContextModel"></a>
<a id="tocSodsinstancecontextmodel"></a>
<a id="tocsodsinstancecontextmodel"></a>

```json
{
  "id": 0,
  "odsInstanceId": 0,
  "contextKey": "string",
  "contextValue": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|none|
|odsInstanceId|integer(int32)|false|none|none|
|contextKey|string¦null|false|none|none|
|contextValue|string¦null|false|none|none|

<h2 id="tocS_odsInstanceDerivativeModel">odsInstanceDerivativeModel</h2>
<!-- backwards compatibility -->
<a id="schemaodsinstancederivativemodel"></a>
<a id="schema_odsInstanceDerivativeModel"></a>
<a id="tocSodsinstancederivativemodel"></a>
<a id="tocsodsinstancederivativemodel"></a>

```json
{
  "id": 0,
  "odsInstanceId": 0,
  "derivativeType": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|none|
|odsInstanceId|integer(int32)¦null|false|none|none|
|derivativeType|string¦null|false|none|none|

<h2 id="tocS_odsInstanceDetailModel">odsInstanceDetailModel</h2>
<!-- backwards compatibility -->
<a id="schemaodsinstancedetailmodel"></a>
<a id="schema_odsInstanceDetailModel"></a>
<a id="tocSodsinstancedetailmodel"></a>
<a id="tocsodsinstancedetailmodel"></a>

```json
{
  "id": 0,
  "name": "string",
  "instanceType": "string",
  "odsInstanceContexts": [
    {
      "id": 0,
      "odsInstanceId": 0,
      "contextKey": "string",
      "contextValue": "string"
    }
  ],
  "odsInstanceDerivatives": [
    {
      "id": 0,
      "odsInstanceId": 0,
      "derivativeType": "string"
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|none|
|name|string¦null|false|none|none|
|instanceType|string¦null|false|none|none|
|odsInstanceContexts|[[odsInstanceContextModel](#schemaodsinstancecontextmodel)]¦null|false|none|none|
|odsInstanceDerivatives|[[odsInstanceDerivativeModel](#schemaodsinstancederivativemodel)]¦null|false|none|none|

<h2 id="tocS_odsInstanceModel">odsInstanceModel</h2>
<!-- backwards compatibility -->
<a id="schemaodsinstancemodel"></a>
<a id="schema_odsInstanceModel"></a>
<a id="tocSodsinstancemodel"></a>
<a id="tocsodsinstancemodel"></a>

```json
{
  "id": 0,
  "name": "string",
  "instanceType": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|none|
|name|string¦null|false|none|none|
|instanceType|string¦null|false|none|none|

<h2 id="tocS_overrideAuthStategyOnClaimSetRequest">overrideAuthStategyOnClaimSetRequest</h2>
<!-- backwards compatibility -->
<a id="schemaoverrideauthstategyonclaimsetrequest"></a>
<a id="schema_overrideAuthStategyOnClaimSetRequest"></a>
<a id="tocSoverrideauthstategyonclaimsetrequest"></a>
<a id="tocsoverrideauthstategyonclaimsetrequest"></a>

```json
{
  "actionName": "string",
  "authorizationStrategies": [
    "string"
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|actionName|string¦null|false|none|none|
|authorizationStrategies|[string]¦null|false|none|none|

<h2 id="tocS_profileDetailsModel">profileDetailsModel</h2>
<!-- backwards compatibility -->
<a id="schemaprofiledetailsmodel"></a>
<a id="schema_profileDetailsModel"></a>
<a id="tocSprofiledetailsmodel"></a>
<a id="tocsprofiledetailsmodel"></a>

```json
{
  "id": 0,
  "name": "string",
  "definition": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)¦null|false|none|none|
|name|string¦null|false|none|none|
|definition|string¦null|false|none|none|

<h2 id="tocS_profileModel">profileModel</h2>
<!-- backwards compatibility -->
<a id="schemaprofilemodel"></a>
<a id="schema_profileModel"></a>
<a id="tocSprofilemodel"></a>
<a id="tocsprofilemodel"></a>

```json
{
  "id": 0,
  "name": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)¦null|false|none|none|
|name|string¦null|false|none|none|

<h2 id="tocS_registerClientRequest">registerClientRequest</h2>
<!-- backwards compatibility -->
<a id="schemaregisterclientrequest"></a>
<a id="schema_registerClientRequest"></a>
<a id="tocSregisterclientrequest"></a>
<a id="tocsregisterclientrequest"></a>

```json
{
  "clientId": "string",
  "clientSecret": "string",
  "displayName": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|clientId|string¦null|false|none|none|
|clientSecret|string¦null|false|none|none|
|displayName|string¦null|false|none|none|

<h2 id="tocS_resourceClaimAction">resourceClaimAction</h2>
<!-- backwards compatibility -->
<a id="schemaresourceclaimaction"></a>
<a id="schema_resourceClaimAction"></a>
<a id="tocSresourceclaimaction"></a>
<a id="tocsresourceclaimaction"></a>

```json
{
  "name": "string",
  "enabled": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|none|
|enabled|boolean|false|none|none|

<h2 id="tocS_resourceClaimActionAuthStrategyModel">resourceClaimActionAuthStrategyModel</h2>
<!-- backwards compatibility -->
<a id="schemaresourceclaimactionauthstrategymodel"></a>
<a id="schema_resourceClaimActionAuthStrategyModel"></a>
<a id="tocSresourceclaimactionauthstrategymodel"></a>
<a id="tocsresourceclaimactionauthstrategymodel"></a>

```json
{
  "resourceClaimId": 0,
  "resourceName": "string",
  "claimName": "string",
  "authorizationStrategiesForActions": [
    {
      "actionId": 0,
      "actionName": "string",
      "authorizationStrategies": [
        {
          "authStrategyId": 0,
          "authStrategyName": "string"
        }
      ]
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|resourceClaimId|integer(int32)|false|none|none|
|resourceName|string¦null|false|none|none|
|claimName|string¦null|false|none|none|
|authorizationStrategiesForActions|[[actionWithAuthorizationStrategy](#schemaactionwithauthorizationstrategy)]¦null|false|none|none|

<h2 id="tocS_resourceClaimActionModel">resourceClaimActionModel</h2>
<!-- backwards compatibility -->
<a id="schemaresourceclaimactionmodel"></a>
<a id="schema_resourceClaimActionModel"></a>
<a id="tocSresourceclaimactionmodel"></a>
<a id="tocsresourceclaimactionmodel"></a>

```json
{
  "resourceClaimId": 0,
  "resourceName": "string",
  "claimName": "string",
  "actions": [
    {
      "name": "string"
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|resourceClaimId|integer(int32)|false|none|none|
|resourceName|string¦null|false|none|none|
|claimName|string¦null|false|none|none|
|actions|[[actionForResourceClaimModel](#schemaactionforresourceclaimmodel)]¦null|false|none|none|

<h2 id="tocS_resourceClaimModel">resourceClaimModel</h2>
<!-- backwards compatibility -->
<a id="schemaresourceclaimmodel"></a>
<a id="schema_resourceClaimModel"></a>
<a id="tocSresourceclaimmodel"></a>
<a id="tocsresourceclaimmodel"></a>

```json
{
  "id": 0,
  "name": "string",
  "parentId": 0,
  "parentName": "string",
  "children": [
    {
      "id": 0,
      "name": "string",
      "parentId": 0,
      "parentName": "string",
      "children": []
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|none|
|name|string¦null|false|none|none|
|parentId|integer(int32)¦null|false|none|none|
|parentName|string¦null|false|none|none|
|children|[[resourceClaimModel](#schemaresourceclaimmodel)]¦null|false|none|none|

<h2 id="tocS_simpleApplicationModel">simpleApplicationModel</h2>
<!-- backwards compatibility -->
<a id="schemasimpleapplicationmodel"></a>
<a id="schema_simpleApplicationModel"></a>
<a id="tocSsimpleapplicationmodel"></a>
<a id="tocssimpleapplicationmodel"></a>

```json
{
  "applicationName": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|applicationName|string¦null|false|none|none|

<h2 id="tocS_vendorModel">vendorModel</h2>
<!-- backwards compatibility -->
<a id="schemavendormodel"></a>
<a id="schema_vendorModel"></a>
<a id="tocSvendormodel"></a>
<a id="tocsvendormodel"></a>

```json
{
  "id": 0,
  "company": "string",
  "namespacePrefixes": "string",
  "contactName": "string",
  "contactEmailAddress": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)¦null|false|none|none|
|company|string¦null|false|none|none|
|namespacePrefixes|string¦null|false|none|none|
|contactName|string¦null|false|none|none|
|contactEmailAddress|string¦null|false|none|none|

