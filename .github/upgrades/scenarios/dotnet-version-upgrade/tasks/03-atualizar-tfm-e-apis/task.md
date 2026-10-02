# 03-atualizar-tfm-e-apis: Atualizar TFM para net10.0-windows e corrigir incompatibilidades

Atualizar o target framework para `net10.0-windows`, ajustar dependências necessárias para APIs Windows e resolver incompatibilidades de compilação identificadas no assessment (incluindo APIs WinForms legadas e uso de `System.Drawing`).

Esta é a etapa central da migração e concentra a maior parte do impacto técnico. O foco é deixar o código compilável no novo target mantendo comportamento funcional equivalente.

**Done when**: Projeto compilando em `net10.0-windows`, com incompatibilidades críticas resolvidas e sem erros de build.

## Scope Inventory

- Projeto afetado: `SistemaHotel\SistemaHotel.csproj`.
- Tipo: WinForms desktop (Windows-only), já convertido para SDK-style no task anterior.
- Concerns deste task:
  1. Troca de TFM para `net10.0-windows`.
  2. Compatibilidade de APIs Windows (`System.Windows.Forms`, `System.Drawing`).
  3. Configuração legada (`System.Configuration`) para compilar no target moderno.

## Assessment Findings (relevantes)

- `Project.0002`: alterar estrutura de destino para `net10.0-windows`.
- `Api.0001`/`Api.0002`: alto volume de incompatibilidades sinalizadas (muitas em WinForms e algumas em `System.Drawing` / `System.Configuration`).
- Tecnologias detectadas: WinForms, WinFormsLegacyControls, GDI+/System.Drawing e LegacyConfiguration.

## Initial Approach

- Atualizar `TargetFramework` para `net10.0-windows`.
- Preservar orientação Windows adicionando compatibilidade necessária em pacotes.
- Executar build e corrigir erros de compilação críticos para deixar o projeto compilável no novo target.
