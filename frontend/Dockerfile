FROM node as build
WORKDIR /app
COPY ./DemoUI/ /app/
RUN npm install
RUN npm run build -- --configuration production --verbose

FROM nginx as final
COPY --from=build /app/dist/* /usr/share/nginx/html/