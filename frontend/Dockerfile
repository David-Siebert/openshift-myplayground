FROM node as build

COPY ./DemoUI/package.json /app/
WORKDIR /app
RUN npm install

COPY ./DemoUI .
RUN npm run build -- --configuration production

FROM nginx as final
COPY --from=build /app/dist/* /usr/share/nginx/html/