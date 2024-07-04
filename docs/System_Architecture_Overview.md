# System Architecture Overview

## Introduction

This document provides a high-level overview of the architecture of the big-data solution designed to track customer behavior, similar to functionalities found in platforms like social media, streaming services, and advertising networks.

## Architecture Diagram

```
+---------------+    +-----------------+    +---------------+
| Front-End     | -> | Backend Service | -> | Kafka Cluster |
| (Web/Mobile)  |    | (API Gateway)   |    |               |
+---------------+    +-----------------+    +---------------+
                            |                      |
                            v                      v
                    +------------------+   +-----------------+
                    | Redis (Session)  |   | Schema Registry |
                    +------------------+   +-----------------+
```

## Components

1. **Front-End:**
   - Interfaces with users through web or mobile platforms.
   - Sends user interaction data to the backend service.

2. **Backend Service:**
   - Validates and processes incoming data.
   - Sends validated data to Kafka for further processing.

3. **Kafka Cluster:**
   - Manages real-time data streaming.
   - Integrates with Kafka Schema Registry for schema management.

4. **Redis:**
   - Manages session data, including session creation and expiration.

5. **Schema Registry:**
   - Central repository for managing Avro schemas.

## Data Flow

1. User interacts with the Front-End.
2. Data is sent to the Backend Service where it is validated.
3. Validated data is published to Kafka.
4. Kafka uses Schema Registry for schema validation and versioning.
5. Sessions are managed concurrently in Redis.

For more detailed architectural decisions, refer to the individual ADRs linked below:
- [ADR 001: Use of Kafka for Event Streaming](ADR_001.md)
- [ADR 002: Use of Kafka Schema Registry](ADR_002.md)
- [ADR 003: Redis for Session Management](ADR_003.md)
