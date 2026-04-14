{{/*
Expand the name of the chart.
*/}}
{{- define "torquemate.name" -}}
{{- default .Chart.Name .Values.nameOverride | trunc 63 | trimSuffix "-" }}
{{- end }}

{{/*
Create a default fully qualified app name.
Truncated at 63 chars because some Kubernetes name fields are limited to this.
*/}}
{{- define "torquemate.fullname" -}}
{{- if .Values.fullnameOverride }}
{{- .Values.fullnameOverride | trunc 63 | trimSuffix "-" }}
{{- else }}
{{- $name := default .Chart.Name .Values.nameOverride }}
{{- if contains $name .Release.Name }}
{{- .Release.Name | trunc 63 | trimSuffix "-" }}
{{- else }}
{{- printf "%s-%s" .Release.Name $name | trunc 63 | trimSuffix "-" }}
{{- end }}
{{- end }}
{{- end }}

{{/*
Create chart label.
*/}}
{{- define "torquemate.chart" -}}
{{- printf "%s-%s" .Chart.Name .Chart.Version | replace "+" "_" | trunc 63 | trimSuffix "-" }}
{{- end }}

{{/*
Common labels applied to every resource.
*/}}
{{- define "torquemate.labels" -}}
helm.sh/chart: {{ include "torquemate.chart" . }}
{{ include "torquemate.selectorLabels" . }}
{{- if .Chart.AppVersion }}
app.kubernetes.io/version: {{ .Chart.AppVersion | quote }}
{{- end }}
app.kubernetes.io/managed-by: {{ .Release.Service }}
{{- end }}

{{/*
Selector labels used by the Deployment and Service.
*/}}
{{- define "torquemate.selectorLabels" -}}
app.kubernetes.io/name: {{ include "torquemate.name" . }}
app.kubernetes.io/instance: {{ .Release.Name }}
{{- end }}

{{/*
ServiceAccount name.
*/}}
{{- define "torquemate.serviceAccountName" -}}
{{- if .Values.serviceAccount.create }}
{{- default (include "torquemate.fullname" .) .Values.serviceAccount.name }}
{{- else }}
{{- default "default" .Values.serviceAccount.name }}
{{- end }}
{{- end }}

{{/*
Resolve the container image tag: prefer values.image.tag, fall back to Chart.AppVersion.
*/}}
{{- define "torquemate.imageTag" -}}
{{- .Values.image.tag | default .Chart.AppVersion }}
{{- end }}

{{/*
Build the Npgsql connection string for INTERNAL mode from postgresql.auth values.
*/}}
{{- define "torquemate.internalConnectionString" -}}
{{- $fullname := include "torquemate.fullname" . -}}
{{- $pg := .Values.postgresql.auth -}}
{{- printf "Host=%s-postgresql; Port=5432; Database=%s; Username=%s; Password=%s;" $fullname $pg.database $pg.username $pg.password }}
{{- end }}

{{/*
Resolve the final connection string:
  1. external.connectionString set     → use verbatim
  2. external individual params        → build Npgsql string
  3. internal mode                     → build from postgresql.auth values
(Not used when existingSecret is set; deployment.yaml references the secret directly.)
*/}}
{{- define "torquemate.connectionString" -}}
{{- if eq .Values.database.mode "external" }}
  {{- if .Values.database.external.connectionString }}
    {{- .Values.database.external.connectionString }}
  {{- else }}
    {{- $e := .Values.database.external -}}
    {{- printf "Host=%s; Port=%d; Database=%s; Username=%s; Password=%s;" $e.host (int $e.port) $e.database $e.username $e.password }}
  {{- end }}
{{- else }}
  {{- include "torquemate.internalConnectionString" . }}
{{- end }}
{{- end }}

{{/*
Name of the Secret holding the DB connection string.
*/}}
{{- define "torquemate.dbSecretName" -}}
{{- if .Values.database.existingSecret }}
{{- .Values.database.existingSecret }}
{{- else }}
{{- include "torquemate.fullname" . }}-db-secret
{{- end }}
{{- end }}

{{/*
Key within the DB secret.
*/}}
{{- define "torquemate.dbSecretKey" -}}
{{- .Values.database.existingSecretKey | default "connection-string" }}
{{- end }}

{{/*
PostgreSQL host for init containers (pg_isready / psql).
*/}}
{{- define "torquemate.pgHost" -}}
{{- if eq .Values.database.mode "internal" }}
{{- include "torquemate.fullname" . }}-postgresql
{{- else }}
{{- .Values.database.external.host }}
{{- end }}
{{- end }}

{{/*
PostgreSQL port for init containers.
*/}}
{{- define "torquemate.pgPort" -}}
{{- if eq .Values.database.mode "internal" }}
5432
{{- else }}
{{- .Values.database.external.port }}
{{- end }}
{{- end }}

{{/*
PostgreSQL username for init containers.
*/}}
{{- define "torquemate.pgUser" -}}
{{- if eq .Values.database.mode "internal" }}
{{- .Values.postgresql.auth.username }}
{{- else }}
{{- .Values.database.external.username }}
{{- end }}
{{- end }}

{{/*
PostgreSQL database name for init containers.
*/}}
{{- define "torquemate.pgDatabase" -}}
{{- if eq .Values.database.mode "internal" }}
{{- .Values.postgresql.auth.database }}
{{- else }}
{{- .Values.database.external.database }}
{{- end }}
{{- end }}

{{/*
PostgreSQL password for init containers.
*/}}
{{- define "torquemate.pgPassword" -}}
{{- if eq .Values.database.mode "internal" }}
{{- .Values.postgresql.auth.password }}
{{- else }}
{{- .Values.database.external.password }}
{{- end }}
{{- end }}
