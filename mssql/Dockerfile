FROM mcr.microsoft.com/azure-sql-edge

COPY setupdb.sql setupdb.sql
COPY entrypoint.sh entrypoint.sh

USER root

RUN chmod +x entrypoint.sh
RUN chown -R 10001:0 setupdb.sql
RUN chown -R 10001:0 entrypoint.sh

USER 10001