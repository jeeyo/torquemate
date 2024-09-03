# TorqueMate Helm Chart

## Get Repo Info

```console
helm repo add torquemate https://jeeyo.github.io/torquemate
helm repo update
```

## Installing the Chart

To install the chart with the release name `my-release`:

```console
helm install my-torquemate torquemate/torquemate
```

## Uninstalling the Chart

To uninstall/delete the my-torquemate deployment:

```console
helm delete my-torquemate
```

## Configuration

| Parameter                                 | Description                                   | Default                                                 |
|-------------------------------------------|-----------------------------------------------|---------------------------------------------------------|
| `replicaCount`                            | Number of nodes                               | `1`                                                     |
| `image.repository`                        | Image repository                              | `ghcr.io/jeeyo/torquemate`                              |
| `image.tag`                               | Image tag whose default is the chart appVersion | ``                                                    |
| `image.pullPolicy`                        | Image pull policy                             | `IfNotPresent`                                          |
| `service.type`                            | Kubernetes service type                       | `ClusterIP`                                             |
| `service.port`                            | Kubernetes port where service is exposed      | `80`                                                    |
