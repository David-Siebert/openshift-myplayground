FROM node as build
WORKDIR /app
COPY ./DemoUI/ /app/
RUN npm install
RUN npm run build -- --configuration production

FROM nginx as final
COPY --from=build /app/nginx.conf /etc/nginx/nginx.conf
COPY --from=build /app/dist/* /usr/share/nginx/html/
RUN chmod -R 777 /etc/nginx/conf.d
RUN chmod -R 777 /var/cache/nginx
RUN chmod -R 777 /var/run
EXPOSE 8080