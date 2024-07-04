# Jacques-Clouseau
Architectural docs and decision records for a big-data solution tracking customer behavior. Includes ADRs, system overviews, and detailed docs on Kafka, Redis, and .NET 8.0/ASP.NET Core, promoting clear design decisions and scalable system architecture.

# Project Architecture Documentation

This repository contains the Architectural Decision Records (ADRs) and other documentation related to the architecture of our big-data solution for tracking customer behavior.

## Table of Contents

1. [System Architecture Overview](docs/System_Architecture_Overview.md)
   - Provides a high-level overview of the entire system architecture, detailing key components and their interactions.
2. [Backend Service Architecture](docs/Backend_Service_Architecture.md)
   - Details the architecture of the backend service, focusing on components, technologies, and observability.
3. Architectural Decision Records (ADRs)
   - [ADR 001: Use of Kafka for Event Streaming](docs/ADR_001.md)
     - Discusses the rationale for choosing Apache Kafka for event streaming over other messaging systems.
   - [ADR 002: Use of Kafka Schema Registry](docs/ADR_002.md)
     - Explains why Kafka Schema Registry is used for managing schema validation and evolution.
   - [ADR 003: Redis for Session Management](docs/ADR_003.md)
     - Describes the decision to use Redis for efficient session management and data expiration.
   - [ADR 004: Choice of .NET and ASP.NET Core](docs/ADR_004.md)
     - Details why .NET and ASP.NET Core were chosen for backend service development.
   - [ADR 005: Use of OpenTelemetry for Observability](docs/ADR_005.md)
     - Discusses the choice of OpenTelemetry for implementing observability (tracing, metrics, logging).
   - [ADR 006: Choice of Prometheus for Metrics Collection](docs/ADR_006.md)
     - Explains why Prometheus was chosen for metrics collection and monitoring.
   - [ADR 007: Security and Data Protection Measures](docs/ADR_007.md)
     - Details the security and data protection measures implemented to ensure data safety and compliance.
   - [ADR 008: API Gateway for Routing and Load Balancing](docs/ADR_008.md)
     - Discusses the decision to use an API Gateway for managing routing, load balancing, and security.

## Overview

The purpose of this documentation is to record architectural decisions made during the project's lifecycle, including choices regarding frameworks, libraries, tools, and patterns used throughout the project. These documents are intended to provide clear guidance and rationale for decisions, aiding in maintenance, scalability, and understanding of the system.

## Architectural Decision Records

Each ADR provides context for why certain decisions were made, alternatives considered, and the outcomes of those decisions. They are vital for understanding the trade-offs and reasoning at various points in the project lifecycle.

## Other Documentation

Besides ADRs, the repository includes detailed documents on system and component architecture. These documents offer in-depth views of the structure and design of the system, ensuring comprehensive knowledge transfer and facilitating easier onboarding for new team members.

## Contributing

To contribute to this documentation, please ensure you follow the guidelines for updating ADRs and submit a pull request for review.

## Contact

For more information or queries regarding the architecture, please contact [kia.panahirad@gmail.com](mailto:kia.panahirad@gmail.com).