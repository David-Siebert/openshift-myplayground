FROM node as build
WORKDIR /app
COPY ./DemoUI/package.json /app/
RUN npm install

COPY ./DemoUI .
RUN npm run build -- --configuration production

FROM nginx as final
COPY --from=build /app/dist/* /usr/share/nginx/html/