FROM node as build
WORKDIR /app
COPY ./DemoUI/ /app/
RUN npm install
RUN npm run build -- --configuration production

FROM nginx as final
COPY --from=build /app/nginx.conf /etc/nginx/nginx.conf
COPY --from=build /app/dist/* /usr/share/nginx/html/
EXPOSE 8080