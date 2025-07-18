# SPDX-License-Identifier: Apache-2.0
# Licensed to the Ed-Fi Alliance under one or more agreements.
# The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
# See the LICENSE and NOTICES files in the project root for more information.

#edfialliance/ods-api-db-admin:7.3
FROM edfialliance/ods-api-db-admin:7.3@sha256:0a25a039e575464de1fdf09b2db270f00910f937cb782dfa809ac3c192509233 AS base
LABEL maintainer="Ed-Fi Alliance, LLC and Contributors <techsupport@ed-fi.org>"

ENV POSTGRES_USER=${POSTGRES_USER}
ENV POSTGRES_PASSWORD=${POSTGRES_PASSWORD}
ENV POSTGRES_DB=postgres

ARG VERSION
ARG ADMIN_API_VERSION
ENV VERSION="${ADMIN_API_VERSION:-2.2.0}"

USER root
COPY run-adminapi-migrations.sh /docker-entrypoint-initdb.d/3-run-adminapi-migrations.sh
RUN apk --upgrade --no-cache add dos2unix=~7 unzip=~6
USER postgres

FROM base AS setup

USER root
RUN wget -nv -O /tmp/EdFi_AdminApi_Scripts.zip "https://pkgs.dev.azure.com/ed-fi-alliance/Ed-Fi-Alliance-OSS/_apis/packaging/feeds/EdFi/nuget/packages/EdFi.Suite3.ODS.AdminApi/versions/${VERSION}/content" && \
    # Admin
    mkdir -p /tmp/AdminApiScripts/Admin/ && \
    unzip /tmp/EdFi_AdminApi_Scripts.zip AdminApi/Artifacts/PgSql/Structure/Admin/* -d /tmp/AdminApiScripts/Admin/ && \
    cp -r /tmp/AdminApiScripts/Admin/AdminApi/Artifacts/PgSql/Structure/Admin/. /tmp/AdminApiScripts/Admin/PgSql/ && \
    rm -r /tmp/AdminApiScripts/Admin/AdminApi && \
    dos2unix /docker-entrypoint-initdb.d/3-run-adminapi-migrations.sh && \
    dos2unix /tmp/AdminApiScripts/Admin/PgSql/* && \
    chmod -R 777 /tmp/AdminApiScripts/Admin/PgSql && \
    # Security
    mkdir -p /tmp/AdminApiScripts/Security/ && \
    unzip /tmp/EdFi_AdminApi_Scripts.zip AdminApi/Artifacts/PgSql/Structure/Security/* -d /tmp/AdminApiScripts/Security/ && \
    cp -r /tmp/AdminApiScripts/Security/AdminApi/Artifacts/PgSql/Structure/Security/. /tmp/AdminApiScripts/Security/PgSql/ && \
    rm -r /tmp/AdminApiScripts/Security/AdminApi && \
    dos2unix /docker-entrypoint-initdb.d/3-run-adminapi-migrations.sh && \
    dos2unix /tmp/AdminApiScripts/Security/PgSql/* && \
    chmod -R 777 /tmp/AdminApiScripts/Security/PgSql && \
    # Clean up
    rm -f /tmp/EdFi_AdminApi_Scripts.zip && \
    apk del dos2unix unzip

USER postgres

EXPOSE 5432

CMD ["docker-entrypoint.sh", "postgres"]
