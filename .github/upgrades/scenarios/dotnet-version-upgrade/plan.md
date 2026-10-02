# .NET Version Upgrade Plan

## Overview

**Target**: Migrar o projeto SistemaHotel de .NET Framework 4.7.2 para .NET 10 (net10.0-windows).
**Scope**: 1 projeto WinForms clássico (~4,2k LOC) com conversão estrutural para SDK-style e alto volume de APIs a compatibilizar.

### Selected Strategy
**All-At-Once** — All projects upgraded simultaneously in a single operation.
**Rationale**: Solução de projeto único em .NET Framework, sem dependências entre múltiplos projetos.

## Tasks

### 01-preparar-ambiente-net10: Verificar pré-requisitos do ambiente de build

Validar se o SDK compatível com .NET 10 está disponível na máquina e se os recursos de build para Windows Desktop estão aptos para compilar WinForms em `-windows`. Esta etapa reduz risco de falha estrutural antes de alterar o projeto.

Também inclui confirmar baseline de build do estado atual para diferenciar problemas preexistentes de regressões da migração.

**Done when**: SDK necessário para .NET 10 confirmado e baseline de build registrada.

---

### 02-converter-csproj-sdk-style: Converter o projeto clássico para SDK-style

Converter `SistemaHotel.csproj` de formato clássico para SDK-style mantendo ainda o comportamento funcional esperado, separando mudança estrutural da mudança de framework. Essa separação é necessária porque os modos de falha são diferentes.

A conversão deve contemplar a migração de propriedades de projeto e referências relevantes para o formato moderno, preparando terreno para a troca de TFM.

**Done when**: O `SistemaHotel.csproj` estiver em formato SDK-style e o projeto compilar no framework atual de transição sem erros estruturais de projeto.

---

### 03-atualizar-tfm-e-apis: Atualizar TFM para net10.0-windows e corrigir incompatibilidades

Atualizar o target framework para `net10.0-windows`, ajustar dependências necessárias para APIs Windows e resolver incompatibilidades de compilação identificadas no assessment (incluindo APIs WinForms legadas e uso de `System.Drawing`).

Esta é a etapa central da migração e concentra a maior parte do impacto técnico. O foco é deixar o código compilável no novo target mantendo comportamento funcional equivalente.

**Done when**: Projeto compilando em `net10.0-windows`, com incompatibilidades críticas resolvidas e sem erros de build.

---

### 04-validar-solucao-pos-migracao: Validar build e testes da solução migrada

Executar validação final com build completo da solução e execução de testes existentes para confirmar que a migração ficou estável. Registrar pendências não bloqueantes para evolução posterior.

Essa etapa fecha a migração com evidências objetivas de sucesso técnico no novo framework.

**Done when**: Build da solução concluído sem erros e suíte de testes existente executada com resultado documentado.
