#!/bin/bash
# SPDX-License-Identifier: Apache-2.0
# Licensed to the Ed-Fi Alliance under one or more agreements.
# The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
# See the LICENSE and NOTICES files in the project root for more information.

set -e
set +x

if [[ -z "$POSTGRES_PORT" ]]; then
  export POSTGRES_PORT=5432
fi

# Force sorting by name following C language sort ordering, so that the sql scripts are run
# sequentially in the correct alphanumeric order
echo "Running Admin Api database migration scripts..."

for FILE in `LANG=C ls /tmp/AdminApiScripts/Admin/PgSql/*.sql | sort -V`
do
    psql --no-password --username "$POSTGRES_USER" --port $POSTGRES_PORT --dbname "EdFi_Admin" --file $FILE 1> /dev/null
done

for FILE in `LANG=C ls /tmp/AdminApiScripts/Security/PgSql/*.sql | sort -V`
do
    psql --no-password --username "$POSTGRES_USER" --port $POSTGRES_PORT --dbname "EdFi_Security" --file $FILE 1> /dev/null
done
