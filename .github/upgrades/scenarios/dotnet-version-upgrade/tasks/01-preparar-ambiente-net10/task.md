# 01-preparar-ambiente-net10: Verificar pré-requisitos do ambiente de build

Validar se o SDK compatível com .NET 10 está disponível na máquina e se os recursos de build para Windows Desktop estão aptos para compilar WinForms em `-windows`. Esta etapa reduz risco de falha estrutural antes de alterar o projeto.

Também inclui confirmar baseline de build do estado atual para diferenciar problemas preexistentes de regressões da migração.

**Done when**: SDK necessário para .NET 10 confirmado e baseline de build registrada.

## Research Notes

- Escopo: projeto único `SistemaHotel.csproj` (WinForms clássico, não SDK-style).
- Ferramenta de build para baseline atual: `msbuild`/build da solução (projeto legado .NET Framework).
- Validações planejadas para este task:
  1. Confirmar disponibilidade de SDK compatível com target `net10.0`.
  2. Registrar baseline de build da solução antes de alterações estruturais.

## Files in Scope

- `SistemaHotel.sln` (somente para validação de baseline)
- `.github/upgrades/scenarios/dotnet-version-upgrade/tasks/01-preparar-ambiente-net10/task.md`
- `.github/upgrades/scenarios/dotnet-version-upgrade/tasks/01-preparar-ambiente-net10/progress-details.md`
